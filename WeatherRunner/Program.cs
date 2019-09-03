using System;
using Weather;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace WeatherRunner
{
    class Program
    {
        static int Main(string[] args)
        {
            var _weatherService = new WeatherService();

            // This would be a great place for a CLI Parsing library.
            if (args.Length < 1)
            {
                System.Console.WriteLine("Please enter a Date argument.");
                System.Console.WriteLine("Usage: WeatherRunner <date>");
                return 1;
            }

            DateTime enteredDate;
            bool test = DateTime.TryParse(args[0], out enteredDate);
            if (test == false)
            {
                System.Console.WriteLine("Please enter a Date argument.");
                System.Console.WriteLine("Usage: WeatherRunner <date>");
                return 1;
            }

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(WeatherDate));
            MemoryStream ms = new MemoryStream();
            js.WriteObject(ms, _weatherService.GetWeather(enteredDate));
            // Console.WriteLine(_weatherService.GetWeather(enteredDate).Serialize());
            ms.Position = 0;
            StreamReader sr = new StreamReader(ms);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            ms.Close();
            return 0;
        }

    }
}
