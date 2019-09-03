using System;
using System.Runtime.Serialization;

namespace Weather
{
    // WeatherDate represents the temp and precipitation numbers for a given day.
    [DataContract]
    public class WeatherDate
    {
        [DataMember]
        public double NormalMaxTemp { get; set; }
        [DataMember]
        public double NormalMinTemp { get; set; }
        [DataMember]
        public double NormalPrecipitation { get; set; }

        public WeatherDate(double max, double min, double precipitation)
        {
            this.NormalMaxTemp = max;
            this.NormalMinTemp = min;
            this.NormalPrecipitation = precipitation;
        }

        // public string Serialize()
        // {
        //     return $"{{ normal_max_temp: {this.NormalMaxTemp}, normal_min_temp: {this.NormalMinTemp}, normal_precipitation: {this.NormalPrecipitation} }}";
        // }
    }
}
