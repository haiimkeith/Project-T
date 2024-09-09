using System;
using System.Collections.Generic;
using System.Text;

namespace Assets.DataTypes
{
    public class Weapon : Item
    {
        //weapons do damage

        float BaseDamage;
        float Damage;

        public Weapon(float damage, string type, string name) : base(type, name)
        {
            BaseDamage = damage;
            Damage = damage;
        }
    }
}
