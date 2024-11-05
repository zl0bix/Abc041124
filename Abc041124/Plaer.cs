using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc041124
{
    internal class Plaer
    {
       public List<Item> _plaerInventory = new List<Item>();

        public void ShowInventoryPlaer()
        {
            Console.WriteLine("Товары игрока:\n");
            if(_plaerInventory.Count == 0)
            {
                Console.WriteLine("У игрока нет предметов (((");
            }
            for (int i = 0; i < _plaerInventory.Count; ++i)
            {             
                if (_plaerInventory[i].multyPlex == 1)
                {
                    Console.Write((i + 1) + "\tтовар\t\t");
                    Console.Write(_plaerInventory[i].nameItem);
                    Console.WriteLine("\tцена\t" + _plaerInventory[i].costItem); //Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (_plaerInventory[i].multyPlex == 2)
                {
                    Console.Write((i + 1) + "\tтовар\t\t");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(_plaerInventory[i].nameItem);
                    Console.ResetColor();
                    Console.WriteLine("\tцена\t" + _plaerInventory[i].costItem);
                }
                else if (_plaerInventory[i].multyPlex == 3)
                {
                    Console.Write((i + 1) + "\tтовар\t\t");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(_plaerInventory[i].nameItem);
                    Console.ResetColor();
                    Console.WriteLine("\tцена\t" + _plaerInventory[i].costItem);
                }
                else
                {
                    Console.Write((i + 1) + "\tтовар\t\t");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(_plaerInventory[i].nameItem);
                    Console.ResetColor();
                    Console.WriteLine("\tцена\t" + _plaerInventory[i].costItem);
                }
            }
        }

        public void AddItemsPlaer(Item item)
        {
            _plaerInventory.Add(item);
        }

        public void AddItemsPlaer(string name, int cost, int rgb)
        {
            _plaerInventory.Add(new Item(name, cost, rgb));
        }
    }
}
