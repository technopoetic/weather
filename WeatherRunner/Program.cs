using System;
using Weather;

namespace WeatherRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading...");
            // var _filename = "weather_data.csv"
            var _weatherService = new WeatherService();

            while(true){
                Console.WriteLine("Enter a date to view the weather for that day.");
                var enteredDate = Console.ReadLine();
                Console.WriteLine($"You entered {enteredDate}.");

                Console.WriteLine(_weatherService.Weather);
            }
        }

    }
}
