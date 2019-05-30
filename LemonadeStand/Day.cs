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
            customers = new List<Customer>();
            weather = new Weather();
            rng = new Random();
        }

        //member methods (CAN DO)
        public void CreateCustomers()
        {
            GetNummberOfCustomers();
            AdjustCustomersBasedOnTemperature();
            for (int i = 0; i < numberOfCustomers; i++)
            {
                CreateCustomer();
            }
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

        public void CreateCustomer()
        {
            Customer customer;
            int customerTypeRoll = rng.Next(0, 7);
            switch (customerTypeRoll)
            {
                case 1:
                    customer = new YoungMan();
                    break;
                case 2:
                    customer = new YoungWoman();
                    break;
                case 3:
                    customer = new LittleBoy();
                    break;
                case 4:
                    customer = new LittleGirl();
                    break;
                case 5:
                    customer = new OldWoman();
                    break;
                case 6:
                    customer = new OldMan();
                    break;
                default:
                    customer = new OldWoman();
                    break;
            }
            customers.Add(customer);
        }
    }
}