﻿namespace Creatures.BestiaryC1o4
{
    internal class Panther : CreatureAttributes
    {

        public Panther()
        {
            Name = "Panther";
            Type = ba;
            Size = m;
            Alignment = ud;
            HitPoints = 13 + RollMultiple(8, 3);
            ArmorClass = 12;
            Speed = "50ft, climb 40ft";
            Attributes = [14, 15, 10, 3, 14, 7];
            ChallengeLevel = "1/4";
            Experience = 50;
            Skills = "Perception +4, Stealth +6";
            Senses = "passive Perceptionk 14";
            Actions = [
                @"
Bite. Melee Weapon Attack: +4 to hit, reach 5 ft, one target.
Hit: 5 (1d6 + 2) piercing damage.",
                @"
Claw. Melee Weapon Attack: +4 to hit, reach 5 ft, one target.
Hit: 4 (1d4 + 2) slashing damage."
                ];
            Abilities = [
                @"
Keen Smell. The panther has advantage on Wisdom
(Perception) checks that rely on smell.",
@"
Pounce. If the panther moves at least 20 feet straight toward a
creature and then hits it with a claw attack on the same turn,
that target must succeed on a DC 12 Strength saving throw or
be knocked prone. If the target is prone, the panther can make
one bite attack against it as a bonus action."
                ];
        }
    }
}
