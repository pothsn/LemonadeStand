using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        //member variables (HAS A)
        public Store store;
        public Player player;
        public List<Day> days;
        public int currentDay;
        public int numberOfDays;


        //constructor (SPAWNER)
        public Game()
        {
            days = new List<Day>();
            currentDay = 1;
            player = new Player();
            store = new Store();
        }


        //member methods (CAN DO)
        public void RunGame()
        {

            DisplayIntroduction();
            numberOfDays = UserPickDays();
            GenerateDays(numberOfDays);
            GeneratePlayerName();
            GameplayLoop();
        }

        public void GameplayLoop()
        {
            foreach (Day day in days)
            {
                Console.WriteLine("Day: " + currentDay + "\nToday's weather: " + day.weather.actualWeather + "\n" + "Today's temperature: " + day.weather.actualTemperature);
                DisplayAllWeatherForecasts();
                DisplayAllTemperatureForecasts();
                Console.WriteLine(player.name + " has $" + player.money);
                store.SellPaperCups(player);
                store.SellLemons(player);
                store.SellCupsOfSugar(player);
                store.SellIceCubes(player);
                Console.WriteLine(player.name + " has:\n" + player.inventory.paperCups + " paper cups\n" + player.inventory.lemons + " lemons\n" + player.inventory.cupsOfSugar + " cups of sugar\n" + player.inventory.iceCubes + " ice cubes.\nPress Enter to continue.");
                Console.ReadLine();
                DetermineIfAdjustPriceAndQuality();
                







                currentDay++;
            }
        }

        public void DisplayIntroduction()
        {
            Console.WriteLine("This is where I will insert a brief introduction describing the game etc. Press Enter to continue.");
            Console.ReadLine();
        }

        public int UserPickDays()
        {
            Console.WriteLine("How many days would you like to play? Enter 7, 14, or 30.");
            int days = int.Parse(Console.ReadLine());
            return days;
        }

        public void GenerateDays(int numberOfDays)
        {
            for (int i = 0; i < numberOfDays; i++)
            {
                Day day = new Day();

                days.Add(day);
            }
        }

        public void GeneratePlayerName()
        {
            Console.WriteLine("Enter player name.");
            player.name = Console.ReadLine();
        }

        public void DisplayAllWeatherForecasts()
        {
            Console.WriteLine("Weather forecast:");
            for (int i = currentDay; i < numberOfDays; i++)
            {
                Console.WriteLine("Day " + i + ": " + days[i].weather.weatherForecast);
            }

        }

        public void DisplayAllTemperatureForecasts()
        {
            Console.WriteLine("Temperature forecast:");
            for (int i = currentDay; i < numberOfDays; i++)
            {
                Console.WriteLine("Day " + i + ": " + days[i].weather.temperatureForecast);
            }
        }

        public void DetermineIfAdjustPriceAndQuality()
        {
            Console.WriteLine("Current recipe:\n" + player.pitcher.cupsOfSugar + " Cups of sugar" + "\n" + player.pitcher.iceCubes + " ice cubes" + "\n" + player.pitcher.lemons + "lemons" + "\n" + "Would you like to adjust it? Enter yes or no.");
            string yesNo = Console.ReadLine().ToLower();
            switch (yesNo)
            {
                case "yes":
                    player.pitcher.AdjustPriceAndQuality();
                    break;
                case "no":
                    break;

            }
                
                







        }
    }
}