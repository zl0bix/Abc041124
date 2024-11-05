using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc041124
{
   

    class Program
    {
        static void Main()
        {
            Item item1 = new Item("Sword", 150, 3);
            Item item2 = new Item("Axe", 110, 2);
            Item item3 = new Item("Bolt", 50, 4);
            Item item4= new Item("Sheld", 120, 1);
            Item item5 = new Item();
            Item item6 = new Item();
            Item item7 = new Item();
            item6 = new Item(item6.RndStrArr(),item6.multyPlex * 50, item6.MuliPlex());
            item7 = new Item(item6.RndStrArr(),item6.multyPlex * 50, item6.MuliPlex());
            Item item8 = new Item();
            item8 =  item8.ReturnItemRnd();
            Item item9 = null;
            //item9 = new Item(item9.ReturnItemRnd());


            Seller seller = new Seller();

            seller.AddItemsSellor(item1);
            seller.AddItemsSellor(item2);
            seller.AddItemsSellor(item3);
            seller.AddItemsSellor(item4);
            seller.AddItemsSellor(item5);
            seller.AddItemsSellor(item6);
            seller.AddItemsSellor(item7);
            seller.AddItemsSellor(item8);
           // seller.AddItemsSellor(item9);

            seller.ShowInventorySellor();

           /* // Пример использования
            Player player = new Player("Игрок 1");
            player.Inventory.AddItem(new Item("Меч", 10));
            player.Inventory.AddItem(new Item("Щит", 5));
            player.Inventory.AddItem(new Item("Броня", 20));

            Console.WriteLine("Инвентарь игрока:");
            player.Inventory.PrintInventory();

            // Пример очистки инвентаря
            player.Inventory.ClearInventory();
            Console.WriteLine("Инвентарь после очистки:");
            player.Inventory.PrintInventory();*/
        }
    }

    /*class Player
    {
        public string Name { get; set; }
        public Inventory Inventory { get; set; }

        public Player(string name)
        {
            Name = name;
            Inventory = new Inventory();
        }
    }

    class Inventory
    {
        private List<Item> _items = new List<Item>();

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public void ClearInventory()
        {
            _items.Clear();
        }

        public void PrintInventory()
        {
            foreach (Item item in _items)
            {
                Console.WriteLine($"{item.Name} - {item.Quantity}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Item(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;*/
   /*     }
    }*/
}
