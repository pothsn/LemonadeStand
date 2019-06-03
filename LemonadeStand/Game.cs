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
        public double totalProfit;

        //constructor (SPAWNER)
        public Game()
        {
            days = new List<Day>();
            currentDay = 0;
            player = new Player();
            store = new Store();
        }


        //member methods (CAN DO)
        public void RunGame()
        {

            DisplayIntroduction();
            numberOfDays = UserPickDays();
            GenerateDays(numberOfDays);
            Console.WriteLine();
            GenerateCustomers();
            GeneratePlayerName();
            Console.WriteLine();
            GameplayLoop();
            Console.WriteLine();
            Console.WriteLine("Game over! Your total profit was " + totalProfit + ". The game will now restart.");
            Console.WriteLine();
            RunGame();
        }

        public void GameplayLoop()
        {
            foreach (Day day in days)
            {
                Console.WriteLine("Day: " + (currentDay + 1));
                Console.WriteLine("Today's weather: " + day.weather.actualWeather);
                Console.WriteLine("Today's temperature: " + day.weather.actualTemperature);
                Console.WriteLine();
                DisplayAllWeatherForecasts();
                Console.WriteLine();
                DisplayAllTemperatureForecasts();
                Console.WriteLine();
                Console.WriteLine(player.name + " has $" + player.money);
                store.SellPaperCups(player);
                store.SellLemons(player);
                store.SellCupsOfSugar(player);
                store.SellIceCubes(player);
                Console.WriteLine(player.name + " has:\n" + "Money: " + player.money + "\n" + player.inventory.paperCups + " paper cups\n" + player.inventory.lemons + " lemons\n" + player.inventory.cupsOfSugar + " cups of sugar\n" + player.inventory.iceCubes + " ice cubes\n" + "$" + player.money + " remaining" + "\nPress Enter to continue.");
                Console.ReadLine();
                DetermineIfAdjustPriceAndQuality();
                Console.WriteLine();
                RunSales();
                currentDay++;
                player.cupsSold = 0;
                store.playerDailyInvestment = 0;
                player.pitcher.cupsInPitcher = 0;
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
            try
            {
                int days = int.Parse(Console.ReadLine());
                if (days == 7 || days == 14 || days == 30)
                {
                    return days;
                }
                else
                {
                    return UserPickDays();
                }
            }
            catch
            {
                return UserPickDays();
            }
        }

        public void GenerateDays(int numberOfDays)
        {
            for (int i = 0; i < numberOfDays; i++)
            {
                Day day = new Day();

                days.Add(day);
            }
        }

        public void GenerateCustomers()
        {
            foreach (Day day in days)
            {
                day.CreateCustomers();
            }
        }

        public void GeneratePlayerName()
        {
            Console.WriteLine("Enter player name.");
            player.name = Console.ReadLine();
            Console.WriteLine("Player name: " + player.name);
        }

        public void DisplayAllWeatherForecasts()
        {
            Console.WriteLine("Weather forecast:");
            for (int i = currentDay; i < numberOfDays; i++)
            {
                Console.WriteLine("Day " + (i + 1) + ": " + days[i].weather.weatherForecast);
            }
        }

        public void DisplayAllTemperatureForecasts()
        {
            Console.WriteLine("Temperature forecast:");
            for (int i = currentDay; i < numberOfDays; i++)
            {
                Console.WriteLine("Day " + (i + 1) + ": " + days[i].weather.temperatureForecast);
            }
        }

        public void DetermineIfAdjustPriceAndQuality()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Current price:\n" + player.pitcher.cupPrice + "\n" + "Current recipe:\n" + player.pitcher.cupsOfSugar + " Cups of sugar" + "\n" + player.pitcher.iceCubes + " ice cubes" + "\n" + player.pitcher.lemons + " lemons" + "\n" + "Would you like to adjust it? Enter yes or no.");
                string yesNo = Console.ReadLine().ToLower();
                switch (yesNo)
                {
                    case "yes":
                        Console.WriteLine();
                        player.pitcher.AdjustPriceAndQuality();
                        break;
                    case "no":
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid input!");
                        DetermineIfAdjustPriceAndQuality();
                        break;

                }
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input!");
                DetermineIfAdjustPriceAndQuality();
            }
        }

        public void RunSales()
        {
            foreach (Customer customer in days[currentDay].customers)
            {
                if (player.pitcher.cupPrice <= customer.pricePreference && player.pitcher.cupsOfSugar >= customer.sugarPreference && player.pitcher.iceCubes >= customer.icePreference && player.pitcher.lemons >= customer.lemonPreference && player.inventory.paperCups > 0)
                {
                    player.SellCup();
                    days[currentDay].dailyProfit += player.pitcher.cupPrice;
                }
                else if(player.pitcher.CheckIfCanRefillPitcher(player.inventory) == false || player.pitcher.cupsInPitcher == 0)
                {
                    Console.WriteLine("Out of supplies!");
                    break;
                }
            }
            days[currentDay].dailyProfit -= store.playerDailyInvestment;
            Console.WriteLine(player.name + " sold " + player.cupsSold + " cups." + "\nDaily profit: " + days[currentDay].dailyProfit + "\nTotal profit: " + CalculateTotalProfit());
            player.inventory.iceCubes = 0;
            Console.WriteLine();
            Console.WriteLine("Your ice melted!");
            Console.WriteLine();
            Console.WriteLine(player.name + " has:\n" + player.inventory.paperCups + " paper cups\n" + player.inventory.lemons + " lemons\n" + player.inventory.cupsOfSugar + " cups of sugar\n" + player.inventory.iceCubes + " ice cubes.\n\nPress Enter to continue.");
            Console.ReadLine();
        }


        public double CalculateTotalProfit()
        {

            totalProfit += days[currentDay].dailyProfit;
            return totalProfit;
            
        }
    }
}