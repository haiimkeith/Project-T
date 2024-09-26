using System;
using System.Collections.Generic;
using System.Text;

namespace Assets.DataTypes
{
    public class Player : Unit
    {
        //this is the unit that the player directly controls

        public int InventorySize;
        public List<Weapon> WeaponsEquipped;
        public List<Ability> Abilities;
        public static List<Ability> startingAbilities;
        public static Weapon startingWeapon;

        Player(string type, int maxHealth, float baseSpeed, string name, List<Weapon> weapons, List<Ability> abilities) 
            : base(type, maxHealth, baseSpeed, name)
        {
            InventorySize = 64;
            WeaponsEquipped = weapons;
            Abilities = abilities;
        }

    }
}
