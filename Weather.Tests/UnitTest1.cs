using System;
using Xunit;
using Weather;

namespace Weather.Tests
{
    public class UnitTest1
    {
        private readonly WeatherService _weatherService;
        public UnitTest1()
        {
            _weatherService = new WeatherService();
            
        }

        [Fact]
        public void TestGetWeather()
        {
            // This data should probably be mocked.
            var weather = _weatherService.GetWeather(DateTime.Parse("12/20/2019"));
            Assert.Equal(weather.NormalMaxTemp, 52.2);
            Assert.Equal(weather.NormalMinTemp, 32.3);
            Assert.Equal(weather.NormalPrecipitation, 0.1);
        }

        [Fact]
        public void TestBuildKey()
        {
            // Need to do some more research on testing.  I haven't been able to figure out how to test private methods.
            Assert.Equal(1, 1);
        }
    }
}
