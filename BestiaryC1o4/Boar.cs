﻿namespace Creatures.BestiaryC1o4
{
    internal class Boar : Creatures
    {
        readonly Dices dice = new();
        public Boar()
        {
            Name = "Boar";
            Type = ba;
            Size = m;
            Alignment = ud;
            HitPoints = 11 + dice.RollMultiple(dice.d8, 2) + 2;
            ArmorClass = 11;
            Speed = "40ft";
            Attributes = [13, 11, 12, 2, 9, 5];
            ChallengeLevel = "1/4";
            Experience = 50;
            Senses = "passive Perception 9";
            Actions = [
                @"
Tusk. Melee Weapon Attack: +3 to hit, reach 5 ft, one target.
Hit: 4 (ld6 + 1) slashing damage."
                ];
            Abilities = [
                @"
Charge. If the boar moves at least 20 feet straight toward a ·
target and then hits it with a tusk attack on the same turn, the
target takes an extra 3 (1 d6) slashing damage. If the target is a
creature, it must succeed on a DC 11 Strength saving throw or
be knocked prone.",
                @"
Relentless (Recharges after a Short or Long Rest). If the boar
takes 7 damage or less that would reduce it to 0 hit points, it is
reduced to 1 hit point instead."
                ];
        }
    }
}
