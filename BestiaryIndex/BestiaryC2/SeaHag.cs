﻿using Base;

namespace BestiaryIndex.BestiaryC2
{
    internal class SeaHag : Creature
    {

        public SeaHag()
        {
            Name = "Sea Hag";
            Type = CreatureTypes.Fey;
            Size = Sizes.Medium;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 52 + RollMultiple(8, 7) + 21;
            ArmorClass = 14;
            Speed = "30ft, swim 40ft";
            AttributeValue = [16, 13, 16, 12, 12, 13];
            ChallengeLevel = "2";
            Experience = 450;
            Senses = "darkvision 60ft, passive Perception 11";
            Languages = "Aquan, Common, Giant";
            Actions = [
                @"
Claws. Melee Weapon Attack: +5 to hit, reach 5 ft., one target.
Hit: 10 (2d6 + 3) slash ing damage.",
                @"
Death Glare. The hag targets one frightened creature she can
see within 30 feet of her. If the target can see the hag, it must
succeed on a DC 11 Wisdom saving throw aga inst this magic or
drop to 0 hit points.",
                @"
Illusory Appearance. The hag covers herself and anything she
is wearing or carrying with a magical illu sion that makes her
look like an ugly creature of her general size and humanoid
shape. The effect ends if the hag takes a bonus action to end it
or if she dies.
The changes wrought by this effect fail to hold up to physical
inspection. For example, the hag could appear to have no
claws, but someone touching her hand might feel the claws.
Otherwise, a creature must take an action to visually inspect
the illusion and succeed on a DC 16 Intelligence (Investigation)
check to di sce rn that the hag is disguised."
                ];
            Abilities = [
                @"
Amphibious. The hag can breathe air and water.",
                @"
Horrific Appearance. Any humanoid that starts its turn within
30 feet of the hag and can see the hag's true form must make
a DC 11 Wisdom saving throw. On a failed save, the creature is
frightened for 1 minute. A creature can repeat the saving throw
at the end of each of its turns , with disadvantage if the hag is
within line of sight, ending the effect on itself on a success. If
a creature's saving throw is successful or the effect ends for it,
the creature is immune to the hag's Horrific Appearance for the
next 24 hours.
Unless the target is surprised or the revelation of the hag's
true fo rm is sudden, the target can avert its eyes and avoid
making the initial saving throw. Until the start of its next turn,
a creature that averts its eyes has disadvantage on attack rolls
agai nst the hag."
                ];
        }
    }
}
