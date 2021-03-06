﻿using IGensoukyo.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouhouHeartstone.Frontend.Model.Witness;

using TouhouCardEngine;

namespace TouhouHeartstone.Frontend.Model
{
    class EventWitnessExecutor
    {
        class ExecuteEnvironment
        {
            readonly EventWitness[] actions;
            readonly DeckController deck;
            readonly GenericAction callback;
            readonly EventWitness parentWitness;

            int currentIndex = 0;

            public ExecuteEnvironment(EventWitness[] actions, DeckController deck, GenericAction callback)
            {
                this.actions = actions;
                this.callback = callback;
                this.deck = deck;
            }
            public ExecuteEnvironment(EventWitness parentWitness, EventWitness[] actions, DeckController deck, GenericAction callback) : this(actions, deck, callback)
            {
                this.parentWitness = parentWitness;
            }

            private void executeNext(object sender, EventArgs args)
            {
                if (currentIndex >= actions.Length)
                {
                    DebugUtils.Debug($"{deck.name}事件序列(长度{actions.Length})执行完毕");
                    callback?.Invoke(sender, args);
                    return;
                }
                else
                {
                    var item = actions[currentIndex++];
                    WitnessExecutor(item, deck, executeNext);
                }
            }

            public void Execute()
            {
                executeNext(null, new EventArgs());
            }
        }

        /// <summary>
        /// 执行一系列的ws
        /// </summary>
        /// <param name="ws"></param>
        /// <param name="deck"></param>
        /// <param name="callback"></param>
        public static void ExecuteWitness(EventWitness[] ws, DeckController deck, GenericAction callback)
        {
            ExecuteEnvironment environment = new ExecuteEnvironment(ws, deck, callback);
            environment.Execute();
        }

        public static void ExecuteWitness(EventWitness ws, DeckController deck, GenericAction callback)
        {
            ExecuteEnvironment environment = new ExecuteEnvironment(new EventWitness[] { ws }, deck, callback);
            environment.Execute();
        }

        private static void WitnessExecutor(EventWitness witness, DeckController deck, GenericAction callback)
        {
            DebugUtils.Debug($"{deck.name}执行事件{witness.eventName}");
            WitnessLibrary.CreateHandler(witness.eventName).HandleWitness(witness, deck, (a, b) =>
            {
                if (witness.child.Count > 0)
                {
                    new ExecuteEnvironment(witness, witness.child.ToArray(), deck, callback).Execute();
                }
                else
                {
                    callback?.Invoke(a, b);
                }
            });
        }
    }
}
