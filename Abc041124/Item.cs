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

       public Random rnd = new Random();

        public Item(string nameItem, int costItem, int multyPlex)
        {
            this.nameItem = nameItem;
            this.costItem = costItem;
            this.multyPlex = multyPlex;
        }

        public Item(Item item)
        {
            nameItem = item.nameItem;
            costItem = item.costItem;
            multyPlex = item.multyPlex;
        }

        public string[] randomaizerNames = { "Axe", "Sword", "Pickaxe", "Hoe", "Bow", "Mjolnir", "Sheld", "Dark Sword" };// 8 el

        public string RndStrArr()
        {
            return randomaizerNames[rnd.Next(0, 7)];
        }

        public Item()
        {
            this.nameItem = "S Axe";
            this.costItem = 1000;
            this.multyPlex = rnd.Next(1,5);
        }
    
        public Item ReturnItemRnd()
        {
            System.Threading.Thread.Sleep(50);
            Random rand = new Random();
            int multy = rand.Next(1, 5);
            int cost = 50 * multy;
            Item tmp = new Item(RndStrArr(), cost, multy);
            return tmp;
        }
        public int MuliPlex() { return rnd.Next(1, 5); }

    }
}
