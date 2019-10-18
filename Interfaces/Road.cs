using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Road
    {
        public List<IDrivable> obj;

        public Road ()
        {
            obj = new List<IDrivable>();
        }

        public void PutOnRoad(IDrivable item)
        {
            if (!obj.Contains(item))
            {
                obj.Add(item);
            }
            else
            {
                Console.WriteLine("Item already exists");
            }
        }

        public void RemoveFromRoad(IDrivable item)
        {
            if (obj.Contains(item))
            {
                obj.Remove(item);
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }
    }
}
