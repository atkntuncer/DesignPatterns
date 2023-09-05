using FlyweightPattern.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class ItemFactory
    {
        HashSet<IItem> itemPool = new HashSet<IItem>();
        public int objectCount { get; private set; }

        public IItem CreateItemA(int id, string name, DateTime date)
        {
            var newItem = new ItemA(id, name,date);

            if (itemPool.TryGetValue(newItem, out var foundItem))
            {
                return foundItem;
            }

            objectCount++;
            itemPool.Add(newItem);
            return newItem;
        }

        public IItem CreateItemB(int id, string name, decimal cost)
        {
            var newItem = new ItemB(id, name, cost);

            if (itemPool.TryGetValue(newItem, out var foundItem))
            {
                return foundItem;
            }

            objectCount++;
            itemPool.Add(newItem);
            return newItem;
        }

        public IItem CreateItemC(int id, string name, string description)
        {
            var newItem = new ItemC(id, name, description);

            if (itemPool.TryGetValue(newItem, out var foundItem))
            {
                return foundItem;
            }

            objectCount++;
            itemPool.Add(newItem);
            return newItem;
        }
    }
}
