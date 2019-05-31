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

        //constructor (SPAWNER)
        public Pitcher()
        {
            cupPrice = .25;
            cupsOfSugar = 4;
            iceCubes = 4;
            lemons = 4;           
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

        public bool CheckPitcher(Inventory inventory)
        {
            while (cupsInPitcher < 1)
            {
                if (inventory.cupsOfSugar >= cupsOfSugar && inventory.iceCubes >= iceCubes && inventory.lemons >= lemons && inventory.paperCups > 0)
                {
                    cupsInPitcher = 11;
                    inventory.cupsOfSugar -= cupsOfSugar;
                    inventory.iceCubes -= iceCubes;
                    inventory.lemons -= lemons;
                }
                else
                {
                    break;
                }
            }
            if (cupsInPitcher > 0)
            {
                cupsInPitcher--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}