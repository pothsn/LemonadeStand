using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        //member variables (HAS A)
        public List<Customer> customer;
        public Weather weather;

        //constructor (SPAWNER)
        public Day()
        {
            weather = new Weather();
        }

        //member methods (CAN DO)
        public void CreateCustomer()
        {

        }


    }
}