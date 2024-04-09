﻿using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class VioletFungus : Creature
    {

        public VioletFungus()
        {
            Name = "Violet Fungus";
            Type = CreatureTypes.Plant;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 18 + RollMultiple(8, 4);
            AttributeValue = [3, 1, 10, 1, 3, 1];
            ArmorClass = 5;
            Speed = "5ft";
            Experience = 50;
            ChallengeLevel = "1/4";
            ConditionImmunities = "blinded, deafened, frightened";
            Senses = "blindsight 30ft (blind beyond this radius)";
            Actions = [
                @"
Miltiattack. The fungus makes 1d4 Rotting Touch attacks.",
                @"
Rotting Touch. Melee Weapon Attack: +2 to hit, reach 10ft, one creature.
Hit: 4 (1d8) necrotic damage."
                ];
            Abilities = [
                @"
False Appearance. While the violet fungus remains motionless, it is
indistinguishable from an ordinary fungus."
                ];

        }
    }
}
