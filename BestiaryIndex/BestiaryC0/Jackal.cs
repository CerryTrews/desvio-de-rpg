using Base;
namespace BestiaryIndex.BestiaryC0
{
    internal class Jackal : Creature
    {

        public Jackal()
        {
            Name = "Jackal";
            Type = CreatureTypes.Beast;
            Size = Sizes.Small;
            Alignment = Alignments.Unaligned;
            HitPoints = 3 + Roll(6);
            AttributeValue = [8, 15, 11, 3, 12, 6];
            ArmorClass = 12;
            Speed = "40ft";
            Experience = 10;
            ChallengeLevel = "0";
            Skills = "Perception +3";
            Senses = "passive Perception 13";
            Actions = [
                @"
Bite. Melee Weapon Attack: +1 to hit, reach 5ft, one target.
Hit: 1 (1d4 - 1) piercing damage"
            ];
            HasMultiAttack = false;
            HasSaveOnAttack = false;
            Abilities = [
                @"
Pack Tactics. The jackal has advantage on an attack roll
against a creature if at least one of the jackal's allies
is within 5 feet of the creature and the ally isn't incapacitated.",
                @"
Keen Hearing and Smell. The jackal has advantage on Wisdom (Perception) checks that rely on hearing or smell."
            ];
            Attacks = 
            [
                new (ActionList.Bite, DamageTypes.Piercing, RangeTypes.Melee, "1d4 - 1")
            ];
        }
    }
}