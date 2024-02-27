﻿namespace Creatures.BestiaryC1
{
    internal class BrassDragonWyrmling : Creatures
    {
        readonly Dices dice = new();
        public BrassDragonWyrmling()
        {
            Name = "Brass Dragon Wyrmling";
            Type = dr;
            Size = m;
            Alignment = cg;
            HitPoints = 16 + dice.RollMultiple(dice.d8, 3) + 3;
            ArmorClass = 16;
            Speed = "30ft, burrow 15ft, fly 60ft";
            Attributes = [15, 10, 13, 10, 11, 13];
            ChallengeLevel = "1";
            Experience = 200;
            SavingThrows = "Dex +2, Con +3, Wis +2, Cha +3";
            DamageImmunities = "fire";
            Skills = "Perception +4, Stealth +2";
            Senses = "blindsight 10ft, darkvision 60ft, passive Perception 14";
            Languages = "Draconic";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
Hit: 7 (1d10 + 2) piercing damage.",
@"
Breath Weapons (Recharge 5-6). The dragon uses one of the
following breath weapons.",
@"
Fire Breath. The dragon exhales fire in an 20-foot line that is
5 feet wide. Each creature in that line must make a DC 11
Dexterity saving throw, taking 14 (4d6) fire damage on a
failed save, or half as much damage on a successfu l one.",
@"
Sleep Breath. The dragon exhales sleep gas in a 15-foot
cone. Each creature in that area must succeed on a DC 11
Constitution saving throw or fall unconscious for 1 minute.
This effect ends for a creature if the creature takes damage or
someone uses an action to wake it."
                ];
        }
    }
}
