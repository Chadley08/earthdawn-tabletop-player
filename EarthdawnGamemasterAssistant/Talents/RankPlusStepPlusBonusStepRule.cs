﻿using System;

namespace EarthdawnGamemasterAssistant.CharacterGenerator.Talents
{
    public class RankPlusStepPlusBonusStepRule : IStepRule
    {
        private int Bonus { get; }

        public RankPlusStepPlusBonusStepRule(int bonus)
        {
            Bonus = bonus;
        }

        public int CalculateStep(int talentRank, int attributeStep)
        {
            throw new NotImplementedException();
        }
    }
}