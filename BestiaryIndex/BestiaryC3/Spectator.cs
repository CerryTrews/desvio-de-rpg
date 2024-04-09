﻿using Base;

namespace BestiaryIndex.BestiaryC3
{
    internal class Spectator : Creature
    {
        public Spectator()
        {
            Name = "Spectator";
            Type = CreatureTypes.Aberration;
            Size = Sizes.Medium;
            Alignment = Alignments.ChaoticEvil;
            HitPoints = 39 + RollMultiple(8, 6) + 12;
            ArmorClass = 14;
            Speed = "0ft, fly 30ft (hover)";
            AttributeValue = [8, 14, 14, 13, 14, 11];
            ChallengeLevel = "3";
            Experience = 700;
            ConditionImmunities = "prone";
            Skills = "Perception +6";
            Senses = "darkvision 120ft, passive Perception 16";
            Languages = "Deep Speech, Undercommon, telepathy 120ft";
            Actions = [
                @"
Bite. Melee Weapon Attack: +1 to hit, reach 5 ft., one target.
Hit: 2 (1d6- 1) piercing damage.",
                @"
Eye Rays. The spectator shoots up to two of the following
magical eye rays at one or two creatures it can see within 90
feet of it. It can use each ray only once on a turn.
1. Confusion Ray. The target must succeed on a DC 13
Wisdom saving throw, or it can't take reactions until the end
of its next turn. On its turn, the target can't move, and it uses
its action to make a melee or ranged attack agaiAst a randomly
determined creature within ran ge. If the target can't attack, it
does nothing on its turn.
2. Paralyzing Ray. The target must succeed on a DC 13
Constitution saving throw or be paralyzed for 1 minute. The
target can repeat the saving throw at the end of each of its
turns, ending the effect on itself on a success.
3. Fear Ray. The target must succeed on a DC 13 Wisdom
saving throw or be frightened for 1 minute. The target can
repeat the saving throw at the end of each of its turns, with
disadvantage if the spectator is visible to the target, ending the
effect on itself on a success.
4. Wounding Ray. The target must make a DC 13 Constitution
saving throw, taking 16 (3d10) necrotic damage on a failed
save, or half as much damage on a successful one.",
                @"
Create Food and Water. The spectator magically creates
enough food and water to sustain itself for 24 hours."
                ];
            Reactions = @"
Spell Reflection. If the spectator makes a successful saving
throw against a spell, or a spell attack misses it, the spectator
can choose another creature (including the spellcaster) it can
see within 30 feet of it. The spell targets the chosen creature
instead of the spectator. If the spell forced a saving throw, the
chosen creature makes its own save. If the spell was an attack,
the attack roll is rerolled against the chosen creature.";
        }
    }
}
