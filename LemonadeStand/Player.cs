using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {
        //member variables (HAS A)
        public double money;
        public Inventory inventory;
        public string name;
        public Pitcher pitcher;
        public int cupsSold;
        public double dailySales;

        //constructor (SPAWNER)
        public Player()
        {
            money = 20.00;
            inventory = new Inventory();
            pitcher = new Pitcher();
        }

        //member methods(CAN DO)

        //public void SellCup()
        //{
        //    if (pitcher.CheckPitcher(inventory))
        //    {
        //        money += pitcher.cupPrice;
        //        cupsSold++;
        //        inventory.paperCups--;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Out of ingredients!");
        //    }
        //}

        public void SellCup()
        {
            
            if (pitcher.CheckPitcher(inventory) == true)
            {
                PourCup();
            }
            if (pitcher.CheckPitcher(inventory) == false)
            {
                if (pitcher.CheckIfCanRefillPitcher(inventory) == true)
                {
                    RefillPitcher(inventory);
                }
            }
        }

        public void PourCup()
        {
            pitcher.cupsInPitcher--;
            inventory.paperCups--;
            money += pitcher.cupPrice;
            cupsSold++;
        }

        public void RefillPitcher(Inventory inventory)
        {
            pitcher.cupsInPitcher = 11;
            inventory.cupsOfSugar -= pitcher.cupsOfSugar;
            inventory.iceCubes -= pitcher.iceCubes;
            inventory.lemons -= pitcher.lemons;
        }






    }
}