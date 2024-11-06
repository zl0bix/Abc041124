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

            sell.AddItemsSeller(program.RandomItems(), program.RandomMultyPlex(), program.RandomCost());
            sell.AddItemsSeller(program.RandomItems(), program.RandomMultyPlex(), program.RandomCost());
            sell.AddItemsSeller(program.RandomItems(), program.RandomMultyPlex(), program.RandomCost());
            sell.AddItemsSeller(program.RandomItems(), program.RandomMultyPlex(), program.RandomCost());
            sell.AddItemsSeller(program.RandomItems(), program.RandomMultyPlex(), program.RandomCost());

            play.AddItemsPlaer(program.RandomItems(), program.RandomMultyPlex(), program.RandomCost());
/*
            sell.ShowInventorySellor();
            play.ShowInventoryPlaer();
*/
            while (!isChoice && logOut != strTemp.ToLower())
            {
                sell.ShowInventorySellor();
                play.ShowInventoryPlaer();

                Console.Write("(1) Нажмите что бы купить\n(2) Нажмите что бы продать\nЧто ты хочешь сделать?\nТвой выбор -> ");

                strTemp = Console.ReadLine();

                if (int.TryParse(strTemp, out num))
                {
                    strTemp = "";

                    switch (num)
                    {
                        case 1:
                            PlayerBuy();
                            break;

                        case 2:
                            SellerBuy();
                            break;

                        default:
                            Console.WriteLine("Неправельный ввод\nНажмите любую клавишу\n");

                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Неправельный ввод\nНажмите любую клавишу\n");

                    Console.ReadKey();
                    Console.Clear();
                }
            }

             void PlayerBuy()
            {
                

                if (sell.LengthOfList())
                {                                        
                        Console.Write("Выбери номер предмета -> ");
                        strTemp = Console.ReadLine();

                    Console.Clear();

                    while (int.TryParse(strTemp, out num))
                    {
                        Console.Clear();

                        strTemp = "";

                        if (sell.LengthOfList(num))
                        {
                            if (play.money > sell.ReturnCostSeller(num))
                            {
                                sell.money += sell.ReturnCostSeller(num);
                                play.money -= sell.ReturnCostSeller(num);

                                play.AddItemsPlaer(sell.ReturnNameSeller(num), sell.ReturnMultyPlex(num), sell.ReturnCostSeller(num));

                                sell.RemuveToIndex(num);

                                sell.ShowInventorySellor();
                                play.ShowInventoryPlaer();

                                Console.WriteLine("Нажмите любую клавишу\n");

                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();

                                sell.ShowInventorySellor();
                                play.ShowInventoryPlaer();

                                Console.WriteLine("У вас нет денег!!!");
                                Console.WriteLine("Нажмите любую клавишу\n");

                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                    }
                }
                else
                {

                    Console.Clear();

                    sell.ShowInventorySellor();
                    play.ShowInventoryPlaer();

                    Console.WriteLine("Товаров нет\n");                   
                    Console.WriteLine("Нажмите любую клавишу\n");

                    Console.ReadKey();
                    Console.Clear();
                }
            }

            void SellerBuy()
            {
                if (play.LengthOfList())
                {
                    Console.Write("Выбери номер предмета -> ");

                    strTemp = Console.ReadLine();

                    Console.Clear();

                    while (int.TryParse(strTemp, out num))
                    {
                        Console.Clear();

                        strTemp = "";

                        if (play.LengthOfList(num))
                        {
                            if (sell.money > play.ReturnCostSeller(num))
                            {
                                play.money += play.ReturnCostSeller(num);
                                sell.money -= play.ReturnCostSeller(num);

                                sell.AddItemsSeller(play.ReturnNameSeller(num), play.ReturnMultyPlex(num), play.ReturnCostSeller(num));

                                play.RemuveToIndex(num);

                                sell.ShowInventorySellor();
                                play.ShowInventoryPlaer();

                                Console.WriteLine("Нажмите любую клавишу\n");

                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();

                                sell.ShowInventorySellor();
                                play.ShowInventoryPlaer();

                                Console.WriteLine("У магазина нет денег!!!");
                                Console.WriteLine("Нажмите любую клавишу\n");

                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                    }
                }
                else
                {
                    Console.Clear();

                    sell.ShowInventorySellor();
                    play.ShowInventoryPlaer();

                    Console.WriteLine("Товаров нет\n");                   
                    Console.WriteLine("Нажмите любую клавишу\n");

                    Console.ReadKey();
                    Console.Clear();
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


        


        
    
    
