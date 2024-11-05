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
            for(int i = 0; i < _sellerInventory.Count; ++i) 
            {
                if (_sellerInventory[i].multyPlex == 1)
                {
                    Console.Write((i + 1) + "\tтовар\t\t");
                    Console.Write(_sellerInventory[i].nameItem);
                    Console.WriteLine("\tцена\t" + _sellerInventory[i].costItem); //Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (_sellerInventory[i].multyPlex == 2)
                {
                    Console.Write((i + 1) + "\tтовар\t\t");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(_sellerInventory[i].nameItem);
                    Console.ResetColor();
                    Console.WriteLine("\tцена\t" + _sellerInventory[i].costItem);
                }
                else if(_sellerInventory[i].multyPlex == 3)
                {
                    Console.Write((i + 1) + "\tтовар\t\t");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(_sellerInventory[i].nameItem);
                    Console.ResetColor();
                    Console.WriteLine("\tцена\t" + _sellerInventory[i].costItem);
                }
                else
                {
                    Console.Write((i + 1) + "\tтовар\t\t");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(_sellerInventory[i].nameItem);
                    Console.ResetColor();
                    Console.WriteLine("\tцена\t" + _sellerInventory[i].costItem);
                }
            }
        }

        public void AddItemsSellor(Item item)
        {
            _sellerInventory.Add(item);
        }
    }
}
