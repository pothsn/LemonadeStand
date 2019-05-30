using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        //member variables (HAS A)
        public List<Customer> customers;
        public Weather weather;
        Random rng;
        int numberOfCustomers;
        

        //constructor (SPAWNER)
        public Day()
        {
            weather = new Weather();
            rng = new Random();
        }

        //member methods (CAN DO)
        public void CreateCustomers()
        {
            GetNummberOfCustomers();
            AdjustCustomersBasedOnTemperature();

        }

        public void GetNummberOfCustomers()
        {
            switch (weather.actualWeather)
            {
                case "sunny":
                    numberOfCustomers = rng.Next(89, 101);
                    break;
                case "cloudy":
                    numberOfCustomers = rng.Next(79, 91);
                    break;
                case "rainy":
                    numberOfCustomers = rng.Next(69, 71);
                    break;
                case "stormy":
                    numberOfCustomers = rng.Next(59, 71);
                    break;
            }
        }

        public void AdjustCustomersBasedOnTemperature()
        {
            if (weather.actualTemperature < 70)
            {
                numberOfCustomers -= 10;
            }
            else if (weather.actualTemperature < 50)
            {
                numberOfCustomers -= 20;
            }
        }

        public void createCustomer()
        {

        }
    }
}