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
            Console.WriteLine("Enter a new price for a cup of lemonade.");
            cupPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter new value for cups of sugar per pitcher.");
            cupsOfSugar = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new value for ice cubes per pitcher.");
            iceCubes = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new value for lemons per pitcher.");
            lemons = int.Parse(Console.ReadLine());
        }

        //public bool CheckPitcher(Inventory inventory)
        //{
        //    if (cupsInPitcher < 1)
        //    {
        //        if (inventory.cupsOfSugar >= cupsOfSugar && inventory.iceCubes >= iceCubes && inventory.lemons >= lemons && inventory.paperCups > 0)
        //        {
        //            cupsInPitcher = 11;
        //            inventory.cupsOfSugar -= cupsOfSugar;
        //            inventory.iceCubes -= iceCubes;
        //            inventory.lemons -= lemons;
        //        }
        //    }
        //    if (cupsInPitcher >= 1 )
        //    {
        //        cupsInPitcher--;
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool CheckPitcher(Inventory inventory)
        {
            if (cupsInPitcher > 0)
                return true;
            else
            {
                return false;
            }
        }

        public bool CheckIfCanRefillPitcher(Inventory inventory)
        {
            if (inventory.cupsOfSugar >= cupsOfSugar && inventory.iceCubes >= iceCubes && inventory.lemons >= lemons && inventory.paperCups > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}