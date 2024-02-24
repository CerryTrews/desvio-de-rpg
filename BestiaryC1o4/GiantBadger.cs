﻿namespace Creatures.BestiaryC1o4
{
    internal class GiantBadger : Creatures
    {
        readonly Dices dice = new();
        public GiantBadger()
        {
            Name = "Giant Badger";
            Type = ba;
            Size = m;
            Alignment = ud;
            HitPoints = 13 + dice.RollMultiple(dice.d8, 2) + 4;
            ArmorClass = 10;
            Speed = "30ft, burrow 10ft";
            Attributes = [13, 10, 15, 2, 12, 5];
            ChallengeLevel = "1/4";
            Experience = 50;
            Senses = "darkvision 30ft, passive Perception 11";
            Actions = [
                @"
Multiattack. The badger makes two attacks: one with its bite
and one with its claws.",
                @"
Bite. Melee Weapon Attack: +3 to hit, reach 5 ft., one target.
Hit: 4 (1d6 + 1) piercing damage.",
                @"
Claws. Melee Weapon Attack: +3 to hit, reach 5 ft., one target.
Hit: 6 (2d4 + 1) slashing damage."
                ];
            Abilities = [
                @"
Keen Smell. The badger has advantage on Wisdom (Perception)
checks that rely on smell."
                ];
        }
    }
}
