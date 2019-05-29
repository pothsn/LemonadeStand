using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        //member variables (HAS A)
        public UserInterface userInterface;
        public Store store;
        public Player player;
        public List<Day> days;


        //constructor (SPAWNER)
        public Game()
        {
            days = new List<Day>();
            player = new Player();
            store = new Store();
        }


        //member methods (CAN DO)
        public void RunGame()
        {
        
            DisplayIntroduction();
            int numberOfDays = UserPickDays();
            GenerateDays(numberOfDays);
            DayActualWeather();
            DayActualTemperature();
            GeneratePlayerName();
            //Gameplay starts here, looping through each day in days?
            GameplayLoop();
            

            
        }

        public void DisplayIntroduction()
        {
            Console.WriteLine("This is where I will insert a brief introduction describing the game etc. Press Enter to continue.");
            Console.ReadLine();
        }
        
        public int UserPickDays()
        {
            Console.WriteLine("How many days would you like to play? Enter 7, 14, or 30.");
            int gameDays = int.Parse(Console.ReadLine());
            return gameDays;
        }

        public void GenerateDays(int numberOfDays)
        {
            for (int i = 0; i < numberOfDays; i++)
            {
                Day day = new Day();
                
                days.Add(day);
            }
        }

        public void DayActualWeather()
        {
            foreach(Day day in days)
            {
                day.weather.GenerateActualWeather();
            }
        }

        public void DayActualTemperature()
        {
            foreach(Day day in days)
            {
                day.weather.GenerateActualTemperature();
            }
        }

        public void GeneratePlayerName()
        {
            Console.WriteLine("Enter player name.");
            player.name = Console.ReadLine();            
        }

        public void GameplayLoop()
        {
            foreach(Day day in days)
            {
                Console.WriteLine("Today's weather: " + day.weather.actualWeather + "\n" + "Today's temperature: " + day.weather.actualTemperature);
                Console.WriteLine("Forecasted weather: " + day.weather.weatherForecast + "Temps: " + day.weather.temperatureForecast);
                Console.WriteLine(player.name + " has $" + player.money);
                store.SellPaperCups(player);









            }
        }






    }
}