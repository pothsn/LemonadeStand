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
        public static string GetStringInput(string output)
        {
            Console.WriteLine(output);
            string input = Console.ReadLine();
            return input;
        }
        public static int GetIntInput(int output)
        {
            Console.WriteLine(output);
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        public static double GetDoubleInput(double output)
        {
            Console.WriteLine(output);
            double input = double.Parse(Console.ReadLine());
            return input;
        }

        //UserInterface.GetInput("Writeline goes here.");

    }
}