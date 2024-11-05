using System;
using System.Collections.Generic;
using System.Data;
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

        //public Random rnd = new Random();

        public Item(string nameItem, int multyPlex, int costItem)
        {
            this.nameItem = nameItem;
            this.multyPlex = multyPlex;
            this.costItem = costItem;
        }

        public Item(Item item)
        {
            nameItem = item.nameItem;
            costItem = item.costItem;
            multyPlex = item.multyPlex;
        }
    }
}

