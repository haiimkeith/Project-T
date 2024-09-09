using System;
using System.Collections.Generic;
using System.Text;

namespace Assets.DataTypes
{
    public class Ability
    {
        //abilities are things units can use to do all sorts of things like attack, dodge, etc

        string Type;
        int Level;

        public Ability(string type, int level)
        {
            Type = type;
            Level = level;
        }
    }
}
