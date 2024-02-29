using Creatures.Main;

namespace Creatures.BEstiaryC1o8
{
    internal class Manes : Creatures
    {
        readonly Dices dice = new();
        public Manes()
        {
            Name = "Manes";
            Type = fi;
            Size = s;
            Alignment = ce;
            HitPoints = 9 + dice.RollMultiple(6, 2) + 2;
            Attributes = [10, 9, 13, 3, 8, 4];
            ArmorClass = 9;
            Speed = "20ft";
            Experience = 25;
            ChallengeLevel = "1/8";
            DamageResistances = "cold, fire, lightning";
            DamageImmunities = "poison";
            ConditionImmunities = "Charmed, Frightened, Poisoned";
            Senses = "darkvision 60ft, passive Perception 9";
            Languages = "understands Abyssal but can't speak";
            Actions = [
                @"
Claws. Melee Weapon Attack: +2 to hit, reach 5 ft., one target.
Hit: 5 (2d4) slashing damage."
                ];
        }
    }
}