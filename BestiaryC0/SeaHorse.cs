using Creatures.Main;

namespace Creatures.BestiaryC0
{
    internal class SeaHorse : Creatures
    {
        readonly Dices dice = new();
        public SeaHorse()
        {
            Name = "Sea Horse";
            Type = ba;
            Size = t;
            Alignment = ud;
            HitPoints = 1 + dice.Roll(4 - 1);
            Attributes = [1, 12, 8, 1, 10, 2];
            ArmorClass = 11;
            Speed = "0ft, swim 20ft";
            Experience = 0;
            ChallengeLevel = "0";
            Senses = "passive Perception 10";
            Abilities = [
                @"
Water Breathing. The sea horse can breathe only underwater."
            ];
        }
    }
}