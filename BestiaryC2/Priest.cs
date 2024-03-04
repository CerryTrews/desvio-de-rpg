﻿namespace Creatures.BestiaryC2
{
    internal class Priest : CreatureAttributes
    {
        public Priest()
        {
            Name = "Priest";
            Type = hu;
            Size = m;
            Alignment = aa;
            HitPoints = 27 + RollMultiple(8, 5) + 5;
            ArmorClass = 13;
            Speed = "25ft";
            Attributes = [10, 10, 12, 13, 16, 13];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Medicide +7, Persuasion +3, Religion +4";
            Senses = "passive Perception 13";
            Languages = "any two languages";
            Actions = [
                @"
Mace. Melee Weapon Attack: +2 to hit,
reach 5 ft., one target . Hit: 3 (ld6)
bludgeoning damage."
                ];
            Abilities = [
                @"
Divine Eminence. As a bonus action, the priest can expend a
spell slot to cause its melee weapon attacks to magically deal
an extra 10 (3d6) radiant damage to a target on a hit . This
benefit lasts until the end of the turn . If the priest expends a
spell slot of 2nd level or higher, the extra damage increases by
ld6 for each level above 1st.",
                @"
Spellcasting. The priest is a 5th-level spellcaster. Its
spellcasting ability is Wisdom (s pell save DC 13 , +5 to
hit with spell attacks). The priest has the following cleric
spells prepared:
Can trips (at will): fight, sacred flame , thaumaturgy
1st level (4 slots): cure wounds, guiding bolt, sanctuary
2nd level (3 slots): lesser restoration,
spiritual weapon
3rd level (2 slots): dispel magic, spirit guardians"
                ];
        }
    }
}
