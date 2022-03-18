using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithSimulator
{
    public class ItemList
    {
        private List<Item> _Items;
        public List<Item> Items { get { return _Items; } set { _Items = value; } }
    }
}
