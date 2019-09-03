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
            DateTime enteredDate;

            // This would be a great place for a CLI Parsing library.
            if (args.Length < 1)
            {
                enteredDate = DateTime.Now;
            }
            else
            {
                bool test = DateTime.TryParse(args[0], out enteredDate);
                if (test == false)
                {
                    System.Console.WriteLine("Please enter a Date argument.");
                    System.Console.WriteLine("Usage: WeatherRunner <date>");
                    return 1;
                }
            }

            // Same here.  This seems awfully verbose just to write some JSON to the console.
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(WeatherDate));
            MemoryStream ms = new MemoryStream();
            js.WriteObject(ms, _weatherService.GetWeather(enteredDate));
            ms.Position = 0;
            StreamReader sr = new StreamReader(ms);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            ms.Close();
            return 0;
        }

    }
}
