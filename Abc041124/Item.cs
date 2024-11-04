using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc041124
{
    internal class Item
    {
        public string nameItem { get; private set; }
        public int costItem { get; private set; }
        public int multyPlex { get; private set; }

        public Item(string nameItem, int costItem, int multyPlex)
        {
            this.nameItem = nameItem;
            this.costItem = costItem;
            this.multyPlex = multyPlex;
        }
    }
}
