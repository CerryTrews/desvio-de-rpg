namespace Creatures.BestiaryC0
{
    internal class Frog : CreatureAttributes
    {

        public Frog()
        {
            Name = "Frog";
            Type = ba;
            Size = t;
            Alignment = ud;
            HitPoints = 1 + Roll(4) - 1;
            Attributes = [1, 13, 8, 1, 8, 3];
            ArmorClass = 11;
            Speed = "20ft, swim 20ft";
            Experience = 0;
            ChallengeLevel = "0";
            Skills = "PErception +1, Stealth +3";
            Senses = "darkvision 30ft, passive Perception 11";

            Abilities = [
               @"
Standing Leap. The frog's long jump is up to 10 feet and
its high jump is up to 5 feet, with or without a running start.",
                @"
Amphibious. The frog can breathe air and water.",
            ];
        }        
    }
}