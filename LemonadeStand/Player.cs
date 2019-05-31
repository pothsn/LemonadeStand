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

        //member methods (CAN DO)

        public void SellCup()
        {
            if (pitcher.CheckPitcher(inventory))
            {
                money += pitcher.cupPrice;
                dailySales += pitcher.cupPrice;
                inventory.paperCups--;
                cupsSold++;
            }
            else
            {
                Console.WriteLine("Out of ingredients!");
            }
        }

    }
}