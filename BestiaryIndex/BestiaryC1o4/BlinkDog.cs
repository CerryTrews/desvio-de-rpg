﻿using Base;

namespace BestiaryIndex.BestiaryC1o4
{
    internal class BlinkDog : Creature
    {

        public BlinkDog()
        {
            Name = "Blink Dog";
            Type = Types.Fey;
            Size = Sizes.Medium;
            Alignment = Alignments.LawfulGood;
            HitPoints = 22 + RollMultiple(8, 4) + 4;
            ArmorClass = 13;
            Speed = "40ft";
            AttributeValue = [12, 17, 12, 10, 13, 11];
            ChallengeLevel = "1/4";
            Experience = 50;
            Skills = "Perception +3, Stealth +5";
            Senses = "passive Perception 13";
            Languages = "Blink Dog, indestands Sylvan but can't speak";
            Actions = [
                @"
Bite. Melee Weapon Attack: +3 to hit, reach 5 ft, one target .
Hit: 4 (1d6 + 1) piercing damage.",
                @"
Teleport (Recharge 4-6). The dog magically teleports, along
with any equipment it is wearing or carrying, up to 40 feet to
an unoccupied space it can see. Before or after teleporting, the
dog can make one bite attack."
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Abilities = [
                @"
Keen Hearing and Smell. The dog has advantage on Wisdom
(Perception) checks that rely on hearing or smell."
                ];
            Attacks =
                [
                new(ActionList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d6 + 1")
                ];
        }
    }
}
