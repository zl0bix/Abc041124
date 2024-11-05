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
        
        public int money = 1000;

        public void ShowInventorySellor()
        {
            Console.WriteLine("Деньги магазина\t" + money + "\nТовары магазина:\n");

            if (_sellerInventory.Count == 0)
            {
                Console.WriteLine("У магазина нет предметов (((\n");
            }
            for (int i = 0; i < _sellerInventory.Count; ++i) 
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
            Console.WriteLine("\n");
        }

        public bool LengthOfList()
        {
            if(_sellerInventory.Count != 0)
                return true;

            return false;
        }

        public void AddItemsSeller(Item item)
        {
            _sellerInventory.Add(item);
        }

        public void AddItemsSeller(string  name, int cost, int rgb) 
        {
            _sellerInventory.Add(new Item(name,cost, rgb));
        }

        public void RemuveToIndex(int index)
        {            
           _sellerInventory.RemoveAt(index - 1);
        }
        public string ReturnNameSeller(int index)
        {
            return _sellerInventory[index -1].nameItem;
        }
        public int ReturnCostSeller(int index)
        {
            return _sellerInventory[index - 1].costItem;
        }
        public int ReturnMultyPlex(int index)
        {
            return _sellerInventory[index - 1].multyPlex;
        }

    }
}
