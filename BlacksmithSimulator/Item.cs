using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithSimulator
{
    public enum Category
    {
        Material,
        Weapon,
        Armor,
        Trinket,
        Ring,
        Necklace
    }
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public List<int> Ingredients { get; set; }
        public Category Category { get; set; }
        
    }
}
