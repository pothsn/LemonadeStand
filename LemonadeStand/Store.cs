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
            lemonsPrice = .08;
            cupsOfSugarPrice = .07;
            iceCubesPrice = .01;
        }


        //member methods (CAN DO)
        public void SellPaperCups(Player player)
        {
            Console.WriteLine("You can buy 25 paper cups for .90, 50 paper cups for 1.60 or 100 paper cups for 3.22. Enter 25, 50 or 100.");
            int playerInput = int.Parse(Console.ReadLine());
            switch (playerInput)
            {
                case 25:
                    player.money -= paperCupsPrice;
                    player.inventory.paperCups += 25;
                    break;
                case 50:
                    player.money -= paperCupsPrice * 2;
                    player.inventory.paperCups += 100;
                    break;
                case 100:
                    player.money -= paperCupsPrice * 4;
                    player.inventory.paperCups += 100;
                    break;
            }







        }




    }
}