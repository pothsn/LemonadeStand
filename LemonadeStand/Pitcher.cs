using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Pitcher
    {
        //member variables (HAS A)
        public int cupsOfSugar;
        public int iceCubes;
        public int lemons;
        public int cupsInPitcher;
        public double cupPrice;
        public int cupsSold;


        //constructor (SPAWNER)
        public Pitcher()
        {
            cupsOfSugar = 4;
            iceCubes = 4;
            lemons = 4;
            cupPrice = .25;
        }

        //member methods (CAN DO)
        public void FillPitcher(Player player)
        {
            if(player.inventory.cupsOfSugar >= cupsOfSugar && player.inventory.iceCubes >= iceCubes && player.inventory.lemons >= lemons && player.inventory.paperCups > 0)
            {
                cupsInPitcher = 11;
            }
            else
            {
                Console.WriteLine("Out of ingredients!");
            }

        }

        public void PourCup(Player player)
        {
            if(cupsInPitcher > 0)
            {
                cupsInPitcher--;
                cupsSold++;
                player.money += cupPrice;
            }
            else
            {
                FillPitcher(player);
            }
        }










    }
}