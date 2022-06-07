using ClassLibrary.Items.Storages.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary.Items.Storages.Models
{
    public class Storage : Item, ILiftable, IStorage
    {
        List<ILiftable> items = new List<ILiftable>();
        public float Weight { get; }
        public float Capacity { get { return items.Sum(x => x.Weight); } }
        public float MaxCapacity { get; }
        public Storage(float weight, float maxCapacity, string name, string description) : base(name, description)
        {
            Weight = weight;
            MaxCapacity = maxCapacity;
        } 
        public bool PutInside(ILiftable item)
        {
            if (item.Weight + Capacity <= MaxCapacity)
            {
                items.Add(item);
                return true;
            }
            else return false;
        }
        public void BrowseInside()
        {

        }
    }
}
