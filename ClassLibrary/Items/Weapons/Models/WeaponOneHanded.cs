using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Items.Weapons.Models
{
    public class WeaponOneHanded : Item, ILiftable
    {
        public float Weight { get;  }
        public WeaponOneHanded(string name, string description, float weight) : base(name, description)
        {
            Weight = weight;
        }
    }
}
