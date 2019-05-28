using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        //member variables (HAS A)
        public List<Day> day;
        public UserInterface userInterface;
        public Store store;
        public Player player;


        //constructor (SPAWNER)
        public Game()
        {



        }


        //member methods (CAN DO)
        public void RunGame()
        {
            DisplayIntroduction();
            int days = SetDays();
            
        }


        public void DisplayIntroduction()
        {
            Console.WriteLine("This is where I will insert a brief introduction describing the game etc. Press Enter to continue.");
            Console.ReadLine();
        }
        
        public int SetDays()
        {
            Console.WriteLine("How many days would you like to play? Enter 7, 14, or 30.");
            int gameDays = int.Parse(Console.ReadLine());
            return gameDays;
        }













    }
}