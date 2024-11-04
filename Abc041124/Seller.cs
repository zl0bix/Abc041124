using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc041124
{
    internal class Seller
    {
        List<Item> _sellerInventory = new List<Item>();

        public void ShowInventorySellor()
        {
            foreach (Item item in _sellerInventory)
            {
                if (item == null)
                    continue;
                Console.WriteLine("Товар " + item.nameItem + " цена " + item.costItem);
            }
        }

        public void AddItemsSellor(Item item)
        {
            _sellerInventory.Add(item);
        }
    }
}
