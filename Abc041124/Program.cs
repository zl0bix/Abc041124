using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc041124
{


    class Program
    {
        Random rnd = new Random();
        static void Main()
        {
            int num;

            string strTemp = "";
            string logOut = "exit";

            bool isChoice = false;

            Program program = new Program();
            Seller sell = new Seller();
            Plaer play = new Plaer();

            sell.AddItemsSellor(program.RandomItems(), program.RandomMultyPlex(),  program.RandomCost() );
            sell.AddItemsSellor(program.RandomItems(), program.RandomMultyPlex(),  program.RandomCost() );
            sell.AddItemsSellor(program.RandomItems(), program.RandomMultyPlex(),  program.RandomCost() );
            //play.AddItemsPlaer(program.RandomItems(), program.RandomMultyPlex(), program.RandomCost());

            sell.ShowInventorySellor();
            play.ShowInventoryPlaer();

            while (!isChoice && logOut != strTemp.ToLower())
            {
                Console.WriteLine("Нажмите 1 что бы купить\n2 что бы продать");
                strTemp = Console.ReadLine();
                if(int.TryParse(strTemp,out num))
                {
                    switch(num)
                    {
                        case 1:
                            Console.Write("Выбери номер предмета -> ");
                            num = Convert.ToInt32(Console.ReadLine());
                            play.AddItemsPlaer(sell.ReturnNameSellor(num),sell.ReturnCostSellor(num),sell.ReturnMultyPlex(num));
                            sell.RemuveToIndex(num);
                            Console.ReadKey();
                            Console.Clear();
                            sell.ShowInventorySellor();
                            play.ShowInventoryPlaer();
                            Console.ReadKey();
                            break;
                    }
                }
            }


        }  
        public string RandomItems()
        {
            string[] randomaizerNames = { "Axe", "Sword", "Pickaxe", "Hoe", "Bow", "Mjolnir", "Sheld", "D Sword" };
            
            return randomaizerNames[rnd.Next(0, 8)];
        }
        public int RandomMultyPlex()
        { 
            return rnd.Next(1, 5);
        }

        public int RandomCost()
        {           
            return rnd.Next(1, 5) * 50;
        }
    }
}   


        


        
    
    
