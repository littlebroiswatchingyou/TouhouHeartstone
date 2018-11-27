﻿using System;
using System.Collections.Generic;

namespace TouhouHeartstone
{
    [Serializable]
    class InitDrawRecord : Record
    {
        int _playerId;
        int _count;
        public InitDrawRecord(int playerId, int count)
        {
            _playerId = playerId;
            _count = count;
        }
        public override Dictionary<int, IWitness> apply(Game game)
        {
            Player player = game.players.getPlayer(_playerId);
            _cards = player.deck.getTopOrRight(_count);
            player.deck.moveTo(_cards, player.hand, true);

            Dictionary<int, IWitness> dicWitness = new Dictionary<int, IWitness>();
            for (int i = 0; i < game.players.count; i++)
            {
                dicWitness.Add(game.players[i].id, new InitDrawWitness(_playerId, _cards.getInstances(_playerId == game.players[i].id)));
            }
            return dicWitness;
        }
        [NonSerialized]
        Card[] _cards = null;
        public override Dictionary<int, IWitness> revert(Game game)
        {
            Player player = game.players.getPlayer(_playerId);
            player.hand.moveTo(_cards, player.deck, true);

            return null;
        }
    }
}