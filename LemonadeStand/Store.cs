﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {
        //member variables (HAS A)
        public double paperCupsPrice; 
        public double lemonsPrice;
        public double cupsOfSugarPrice;
        public double iceCubesPrice;
        public double playerDailyInvestment;
                
        //constructor (SPAWNER)
        public Store()
        {
            paperCupsPrice = .90;
            lemonsPrice = .94;
            cupsOfSugarPrice = .56;
            iceCubesPrice = .01;
        }


        //member methods (CAN DO)
        public void SellPaperCups(Player player)
        {
            try
            {
                Console.WriteLine("You can buy 25 paper cups for .90, 50 paper cups for 1.60 or 100 paper cups for 3.22. Enter 0, 25, 50 or 100.");
                int playerInput = int.Parse(Console.ReadLine());

                if (playerInput == 0 || playerInput == 25 || playerInput == 50 || playerInput == 100)
                {
                    switch (playerInput)
                    {
                        case 0:
                            Console.WriteLine();
                            break;
                        case 25:
                            if (player.money >= paperCupsPrice)
                            {
                                Console.WriteLine();
                                player.money -= paperCupsPrice;
                                player.inventory.paperCups += 25;
                                playerDailyInvestment += paperCupsPrice;
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Not enough money!");
                                SellPaperCups(player);
                                break;
                            }
                        case 50:
                            if (player.money >= 1.60)
                            {
                                Console.WriteLine();
                                player.money -= 1.60;
                                player.inventory.paperCups += 50;
                                playerDailyInvestment += 1.60;
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Not enough money!");
                                SellPaperCups(player);
                                break;
                            }
                        case 100:
                            if (player.money >= 3.22)
                            {
                                Console.WriteLine();
                                player.money -= 3.22;
                                player.inventory.paperCups += 100;
                                playerDailyInvestment += 3.22;
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Not enough money!");
                                SellPaperCups(player);
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input!");
                    SellPaperCups(player);
                }
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input!");
                SellPaperCups(player);
            }
        }

        public void SellLemons(Player player)
        {
            try
            {
                Console.WriteLine("You can buy 10 lemons for .94, 30 lemons for 2.40 or 75 lemons for 4.13. Enter 0, 10, 30 or 75.");
                int playerInput = int.Parse(Console.ReadLine());
                if (playerInput == 0 || playerInput == 10 || playerInput == 30 || playerInput == 75)
                {
                    switch (playerInput)
                    {
                        case 0:
                            Console.WriteLine();
                            break;
                        case 10:
                            if (player.money >= lemonsPrice)
                            {
                                Console.WriteLine();
                                player.money -= lemonsPrice;
                                player.inventory.lemons += 10;
                                playerDailyInvestment += lemonsPrice;
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Not enough money!");
                                SellLemons(player);
                                break;
                            }
                        case 30:
                            if (player.money >= 2.40)
                            {
                                Console.WriteLine();
                                player.money -= 2.40;
                                player.inventory.lemons += 30;
                                playerDailyInvestment += 2.40;
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Not enough money!");
                                SellLemons(player);
                                break;
                            }
                        case 75:
                            if (player.money >= 4.13)
                            {
                                Console.WriteLine();
                                player.money -= 4.13;
                                player.inventory.lemons += 75;
                                playerDailyInvestment += 4.13;
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Not enough money!");
                                SellLemons(player);
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input!");
                    SellLemons(player);
                }
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input!");
                SellLemons(player);
            }
        }

        public void SellCupsOfSugar(Player player)
        {
            try
            {
                Console.WriteLine("You can buy 8 cups of sugar for .56, 20 cups of sugar for 1.51 or 48 cups of sugar for 3.39. Enter 0, 8, 20 or 48.");
                int playerInput = int.Parse(Console.ReadLine());
                if (playerInput == 0 || playerInput == 8 || playerInput == 20 || playerInput == 48)
                {
                    switch (playerInput)
                    {
                        case 0:
                            Console.WriteLine();
                            break;
                        case 8:
                            if (player.money >= cupsOfSugarPrice)
                            {
                                Console.WriteLine();
                                player.money -= cupsOfSugarPrice;
                                player.inventory.cupsOfSugar += 8;
                                playerDailyInvestment += cupsOfSugarPrice;
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Not enough money!");
                                SellCupsOfSugar(player);
                                break;
                            }
                        case 20:
                            if (player.money >= 1.51)
                            {
                                Console.WriteLine();
                                player.money -= 1.51;
                                player.inventory.cupsOfSugar += 20;
                                playerDailyInvestment += 1.51;
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Not enough money!");
                                SellCupsOfSugar(player);
                                break;
                            }
                        case 48:
                            if (player.money >= 3.39)
                            {
                                Console.WriteLine();
                                player.money -= 3.39;
                                player.inventory.cupsOfSugar += 48;
                                playerDailyInvestment += 3.39;
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Not enough money!");
                                SellCupsOfSugar(player);
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input!");
                    SellCupsOfSugar(player);
                }
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input!");
                SellCupsOfSugar(player);
            }
        }

        public void SellIceCubes(Player player)
        {
            try
            {
                Console.WriteLine("You can buy 100 ice cubes for .89, 250 ice cubes for 2.08 or 500 ice cubes for 3.61. Enter 0, 100, 250 or 500.");
                int playerInput = int.Parse(Console.ReadLine());
                if (playerInput == 0 || playerInput == 100 || playerInput == 250 || playerInput == 500)
                {
                    switch (playerInput)
                    {
                        case 0:
                            Console.WriteLine();
                            break;
                        case 100:
                            if (player.money >= iceCubesPrice)
                            {
                                Console.WriteLine();
                                player.money -= iceCubesPrice;
                                player.inventory.iceCubes += 100;
                                playerDailyInvestment += iceCubesPrice;
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Not enough money!");
                                SellIceCubes(player);
                                break;
                            }
                        case 250:
                            if (player.money >= 2.08)
                            {
                                Console.WriteLine();
                                player.money -= 2.08;
                                player.inventory.iceCubes += 250;
                                playerDailyInvestment += 2.08;
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Not enough money!");
                                SellIceCubes(player);
                                break;
                            }
                        case 500:
                            if (player.money >= 3.61)
                            {
                                Console.WriteLine();
                                player.money -= 3.61;
                                player.inventory.iceCubes += 500;
                                playerDailyInvestment += 3.61;
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Not enough money!");
                                SellIceCubes(player);
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input!");
                    SellIceCubes(player);
                }
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input!");
                SellIceCubes(player);
            }
        }
    }
}