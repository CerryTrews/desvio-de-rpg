﻿using Base;
namespace BestiaryIndex.BestiaryC0
{
    internal class Baboon : Creature
    {

        public Baboon()
        {
            Name = "Baboon";
            Type = Types.Beast;
            Size = Sizes.Small;
            Alignment = Alignments.Unaligned;
            HitPoints = 3 + Roll(6);
            AttributeValue = [8, 14, 11, 4, 12, 6];
            ArmorClass = 12;
            Speed = "30ft, climb 30ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "passive Perception 11";
            Actions = [
                @"
Bite. Melee Weapon Attack: +1 to hit, reach 5 ft, one target.
Hit: 1 (1d4- 1), piercing damage."
                ];

            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Abilities = [
                @"
Pack Tactics. The baboon has advantage on an attack roll against a creature
if at least one of the baboon's allies is within 5 feet of the creature and
the ally isn't incapacitated.",
                ];

            Attacks =
            [
                new (ActionList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d4-1")
            ];

        }
    }
}

