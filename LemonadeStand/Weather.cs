using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        //member variables (HAS A)
        Random rng;
        public string weather;



        //constructor (SPAWNER)
        public Weather()
        {
            rng = new Random();
            GenerateWeatherForecast();
            GenerateTemperatureForecast();
        }

        //member methods (CAN DO)
        public string GenerateWeatherForecast()
        {
            int weatherRoll = rng.Next(4);
            switch (weatherRoll)
            {
                case 0:
                    weather = "sunny";
                    break;
                case 1:
                    weather = "cloudy";
                    break;
                case 2:
                    weather = "rainy";
                    break;
                case 3:
                    weather = "stormy";
                    break;
            }
            return weather;
        }

        public int GenerateTemperatureForecast()
        {
            int temperatureRoll = rng.Next(40, 90);
            return temperatureRoll;
        }


    }
}