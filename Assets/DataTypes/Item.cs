using System;
using System.Collections.Generic;
using System.Text;

namespace Assets.DataTypes
{
    public class Item
    {
        //Items can be picked up by the player and/or possibly npc's. They can be stored in inventory, used,
        //destroyed, etc.

        public string Type;
        public string Name;
        
        public Item(string type, string name = "nameless")
        {
            Type = type;
            Name = name;
        }

        //probably gonna have some functions for using/picking up in here
    }
}
