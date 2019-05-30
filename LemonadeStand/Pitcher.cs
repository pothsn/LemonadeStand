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
        

        public void AdjustPriceAndQuality()
        {
            Console.WriteLine("Enter new value for cups of sugar per pitcher.");
            cupsOfSugar = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new value for ice cubes per pitcher.");
            iceCubes = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new value for lemons per pitcher.");
            lemons = int.Parse(Console.ReadLine());
        }








        public void FillPitcher(Inventory inventory)
        {
            if(inventory.cupsOfSugar >= cupsOfSugar && inventory.iceCubes >= iceCubes && inventory.lemons >= lemons && inventory.paperCups > 0)
            {
                cupsInPitcher = 11;
            }
            else
            {
                Console.WriteLine("Out of ingredients!");
            }

        }

        public void PourCup(Inventory inventory)
        {
            if (cupsInPitcher > 0)
            {
                cupsInPitcher--;
                cupsSold++;
            }
            else
            {
                FillPitcher(inventory);

            }

        }
    }
}