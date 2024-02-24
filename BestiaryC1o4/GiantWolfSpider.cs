﻿namespace Creatures.BestiaryC1o4
{
    internal class GiantWolfSpider : Creatures
    {
        readonly Dices dice = new();
        public GiantWolfSpider()
        {
            Name = "Giant Wolf Spider";
            Type = ba;
            Size = m;
            Alignment = ud;
            HitPoints = 11 + dice.RollMultiple(dice.d8, 2) + 2;
            ArmorClass = 13;
            Speed = "40ft, climb 40ft";
            Attributes = [12, 16, 13, 3, 12, 4];
            ChallengeLevel = "1/4";
            Experience = 50;
            Skills = "Perception +3, Stealth +7";
            Senses = "blindsight 10ft, darkvision 60ft, passive Perception 13";
            Actions = [
                @"
Bite. Melee Weapon Attack: +3 to hit, reach 5 ft, one creature.
Hit: 4 (1d6 + 1) piercing damage, and the target must make a
DC 11 Constitution saving throw, taking 7 (2d6) poison damage
on a failed save, or half as much damage on a successful one.
If the poison damage reduces the target to 0 hit points, the
target is stable but poisoned for 1 hour, even after regaining hit
points, and is paralyzed while poisoned in this way."
                ];
            Abilities = [
                @"
Spider Climb. The spider can climb difficult surfaces, including
upside down on ceilings, without needing to make an
ability check.",
                @"
Web Sense. While in contact with a web, the spider knows
the exact location of any other creature in contact with
the same web.",
                @"
Web Walker. The spider ignores movement restrictions caused
by webbing."
                ];
        }
    }
}
