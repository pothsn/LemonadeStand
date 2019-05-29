using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {
        //member variables (HAS A)
        //public Player player;
        public double paperCupsPrice; 
        public double lemonsPrice;
        public double cupsOfSugarPrice;
        public double iceCubesPrice;
                
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
            Console.WriteLine("You can buy 25 paper cups for .90, 50 paper cups for 1.60 or 100 paper cups for 3.22. Enter 0, 25, 50 or 100.");
            int playerInput = int.Parse(Console.ReadLine());
            switch (playerInput)
            {
                case 0:
                    break;
                case 25:
                    player.money -= paperCupsPrice;
                    player.inventory.paperCups += 25;
                    break;
                case 50:
                    player.money -= 1.60;
                    player.inventory.paperCups += 100;
                    break;
                case 100:
                    player.money -= 3.22;
                    player.inventory.paperCups += 100;
                    break;
            }
        }

        public void SellLemons(Player player)
        {
            Console.WriteLine("You can buy 10 lemons for .94, 30 lemons for 2.40 or 75 lemons for 4.13. Enter 0, 10, 30 or 75.");
            int playerInput = int.Parse(Console.ReadLine());
            switch (playerInput)
            {
                case 0:
                    break;
                case 10:
                    player.money -= lemonsPrice;
                    player.inventory.lemons += 10;
                    break;
                case 30:
                    player.money -= 2.40;
                    player.inventory.lemons += 30;
                    break;
                case 75:
                    player.money -= 4.13;
                    player.inventory.lemons += 75;
                    break;
            }
        }

        public void SellCupsOfSugar(Player player)
        {
            Console.WriteLine("You can buy 8 cups of sugar for .56, 20 cups of sugar for 1.51 or 48 cups of sugar for 3.39. Enter 0, 8, 20 or 48.");
            int playerInput = int.Parse(Console.ReadLine());
            switch (playerInput)
            {
                case 0:
                    break;
                case 8:
                    player.money -= cupsOfSugarPrice;
                    player.inventory.cupsOfSugar += 8;
                    break;
                case 20:
                    player.money -= 1.51;
                    player.inventory.cupsOfSugar += 20;
                    break;
                case 48:
                    player.money -= 3.39;
                    player.inventory.cupsOfSugar += 48;
                    break;
            }
        }

        public void SellIceCubes(Player player)
        {
            Console.WriteLine("You can buy 100 ice cubes for .89, 250 ice cubes for 2.08 or 500 ice cubes for 3.61. Enter 0, 100, 250 or 500.");
            int playerInput = int.Parse(Console.ReadLine());
            switch (playerInput)
            {
                case 0:
                    break;
                case 100:
                    player.money -= iceCubesPrice;
                    player.inventory.iceCubes += 100;
                    break;
                case 250:
                    player.money -= 2.08;
                    player.inventory.iceCubes += 250;
                    break;
                case 500:
                    player.money -= 3.61;
                    player.inventory.iceCubes += 500;
                    break;
            }
        }






    }
}