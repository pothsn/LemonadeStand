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
            int customerTypeRoll = rng.Next(0, 7);
            switch (customerTypeRoll)
            {
                case 1:
                    YoungMan youngMan = new YoungMan();
                    customers.Add(youngMan);
                    break;
                case 2:
                    YoungWoman youngWoman = new YoungWoman();
                    customers.Add(youngWoman);
                    break;
                case 3:
                    LittleBoy littleBoy = new LittleBoy();
                    customers.Add(littleBoy);
                    break;
                case 4:
                    LittleGirl littleGirl = new LittleGirl();
                    customers.Add(littleGirl);
                    break;
                case 5:
                    OldWoman oldWoman = new OldWoman();
                    customers.Add(oldWoman);
                    break;
                case 6:
                    OldMan oldMan = new OldMan();
                    customers.Add(oldMan);
                    break;


            }
        }
    }
}