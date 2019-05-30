using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public static class UserInterface
    {
        //member variables (HAS A)

        //constructor (SPAWNER)
        static UserInterface()
        {





        }

        //member methods (CAN DO)
        public static string GetInput(String output)
        {
            Console.WriteLine(output);
            string input = Console.ReadLine();
            return input;
        }
        //UserInterface.GetInput("Writeline goes here.");

    }
}