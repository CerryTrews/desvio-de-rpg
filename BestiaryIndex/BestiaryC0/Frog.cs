using Base;

namespace BestiaryIndex.BestiaryC0
{
    internal class Frog : Creature
    {

        public Frog()
        {
            Name = "Frog";
            Type = CreatureTypes.Beast;
            Size = Sizes.Tiny;
            Alignment = Alignments.Unaligned;
            HitPoints = 1 + Roll(4) - 1;
            AttributeValue = [1, 13, 8, 1, 8, 3];
            ArmorClass = 11;
            Speed = "20ft, swim 20ft";
            Experience = 0;
            ChallengeLevel = "0";
            Skills = "Perception +1, Stealth +3";
            Senses = "darkvision 30ft, passive Perception 11";

            Abilities = [
               @"
Standing Leap. The frog's long jump is up to 10 feet and
its high jump is up to 5 feet, with or without a running start.",
                @"
Amphibious. The frog can breathe air and water.",
            ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Attacks = 
            [
                new (ActionList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d2" )
            ];
        }
    }
}