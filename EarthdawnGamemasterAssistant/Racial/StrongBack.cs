﻿using System;
using EarthdawnGamemasterAssistant.CharacterGenerator.Attributes;

namespace EarthdawnGamemasterAssistant.CharacterGenerator.Racial
{
    public class StrongBack : RacialAbility
    {
        public StrongBack() : base(
            "Strong Back",
            "Dwarf charaters have a +2 bonus to their Strength for the purposes of determining carrying capacity. (Note that this is already accounted for on your character sheet.)")
        {
        }
    }
}