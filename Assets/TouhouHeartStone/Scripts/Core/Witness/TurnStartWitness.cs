﻿using System;

namespace TouhouHeartstone
{
    [Serializable]
    public struct TurnStartWitness : IWitness
    {
        public int number { get; set; }
        public int playerId { get; }
        public TurnStartWitness(int playerId)
        {
            number = 0;
            this.playerId = playerId;
        }
        public override string ToString()
        {
            return "玩家" + playerId + "的回合开始";
        }
    }
}