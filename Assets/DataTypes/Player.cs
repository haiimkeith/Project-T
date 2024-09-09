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

        Player(string type, int maxHealth, float baseSpeed, string name = "Hero", List<Weapon> weapons = new List<Weapon> { startingWeapon }, List<Ability> abilities = new List<Ability>{ startingAbilities }) 
            : base(type, maxHealth, baseSpeed, name)
        {
            InventorySize = inventorySize;
            WeaponsEquipped = weapons;
            Abilities = abilities;
        }

        public static List<Ability> startingAbilities;
        public static Weapon startingWeapon;
    }
}
