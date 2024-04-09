using Base;
namespace BestiaryIndex.BestiaryC0
{
    internal class Rat : Creature
    {

        public Rat()
        {
            Name = "Rat";
            Type = CreatureTypes.Beast;
            Size = Sizes.Tiny;
            Alignment = Alignments.Unaligned;
            HitPoints = 1 + Roll(4) - 1;
            AttributeValue = [2, 11, 9, 2, 10, 4];
            ArmorClass = 10;
            Speed = "20ft";
            Experience = 10;
            ChallengeLevel = "0";
            Senses = "darkvision 30ft, passive Perception 10";
            Actions = [
                @"
Bite. Melee Weapon Attack: +0 to hit, reach 5f, one target.
Hit 1 piercing damage"
                ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Abilities = [
                @"
Keen Smell. The rat has advantage on Wisdom (Perception) checks
that rely on smell."
            ];
            Attacks = 
            [
                new (ActionList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d1")
            ];
        }
    }
}