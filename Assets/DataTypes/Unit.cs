using System;
using System.Collections.Generic;
using System.Text;

namespace Assets.DataTypes
{
    public class Unit
    {
        //A unit is any "entity" in the game that does stuff on it's own. The player character and all NPC's
        //are Units. All friendlies, enemies, neutrals, bosses are enemies.

        public string Type;
        public string Name;
        public int MaxHealth;
        public float BaseSpeed;
        public int Health;
        public float Speed;

        public Unit(string type, int maxHealth, float baseSpeed, string name = "")
        {
            Type = type;
            MaxHealth = maxHealth;
            BaseSpeed = baseSpeed;
            Speed = baseSpeed;
            Health = maxHealth;
            Name = name;
        }
    }
}
