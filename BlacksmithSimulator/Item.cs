using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithSimulator
{

    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public List<string> Ingredients { get; set; }
        public string Category { get; set; }
        
    }
}
