using System;
using System.IO;
using System.Collections.Generic;

namespace Weather
{
    public class WeatherService
    {
        // WeatherService contains a Dictionary of day - weather mappings, and allows us to access those.
        // WeatherList is just a hash table:
        // <month>_<day>: { max_temp: <value>, min_temp: <value>, precipitation: <value> }
        private Dictionary<string, WeatherDate> WeatherList;

        public WeatherService()
        {
            this.WeatherList = new Dictionary<string, WeatherDate>();

            foreach (string line in File.ReadLines(@"../weather-data.txt"))
            {
                {
                    var fields = line.Split(',');
                    if(fields[5] == "N/A")
                    {
                        fields[5] = "0";
                    }
                    var _weather = new WeatherDate( Convert.ToDouble(fields[3]), Convert.ToDouble(fields[4]), Convert.ToDouble(fields[5]));
                    this.WeatherList.Add(BuildKey(fields), _weather);
                }
            }
        }

        // GetWeather returns a WeatherDate object given a DateTime
        public WeatherDate GetWeather(DateTime date)
        {
            var date_fields = new string[2];
            date_fields[0] = date.ToString("MMMM");
            date_fields[1] = date.Day.ToString();
            return this.WeatherList[BuildKey(date_fields)];
        }

        // I don't think we can use the Julian day, since it changes.  Just use the 
        // Month and day as a string.
        // TODO: This is an example where "grooming" comes into play.  Do we need to access the forecasts by Julian day?
        // What's the actual use case?
        private string BuildKey(string[] fields)
        {
            return fields[0] + '_' + fields[1];
        }
    }
}
