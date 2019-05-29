using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        //member variables (HAS A)
        Random rng;
        public string weatherForecast;
        public string actualWeather;
        public int temperatureForecast;
        public int actualTemperature;



        //constructor (SPAWNER)
        public Weather()
        {
            rng = new Random();
            GenerateWeatherForecast();
            GenerateTemperatureForecast();
            GenerateActualWeather();
            actualTemperature = GenerateActualTemperature();

        }

        //member methods (CAN DO)
        private string GenerateWeatherForecast()
        {
            int weatherRoll = rng.Next(4);
            switch (weatherRoll)
            {
                case 0:
                    weatherForecast = "sunny";
                    break;
                case 1:
                    weatherForecast = "cloudy";
                    break;
                case 2:
                    weatherForecast = "rainy";
                    break;
                case 3:
                    weatherForecast = "stormy";
                    break;
            }
            return weatherForecast;
        }

        private int GenerateTemperatureForecast()
        {
            temperatureForecast = rng.Next(40, 101);
            return temperatureForecast;
        }

        public void GenerateActualWeather()
        {
            int actualWeatherRoll = rng.Next(1, 11);
            if(actualWeatherRoll >= 7)
            {
                actualWeather = "sunny";               
            }
            else
            {
                actualWeather = weatherForecast;
            }
        }

        public int GenerateActualTemperature()
        {
            int actualTemperatureRoll = rng.Next(-4, 4);
            actualTemperature = temperatureForecast + actualTemperatureRoll;
            return actualTemperature;
        }




    }
}