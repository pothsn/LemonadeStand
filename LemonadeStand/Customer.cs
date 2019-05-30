using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Customer
    {
        //member variables (HAS A)
        public double pricePreference;
        public int sugarPreference;
        public int icePreference;
        public int lemonPreference;
        public int temperatureInfluence;

        //constructor (SPAWNER)
        public Customer()
        {
            pricePreference = .25;
            sugarPreference = 4;
            icePreference = 4;
            lemonPreference = 4;
        }

        //member methods (CAN DO)


    }
}