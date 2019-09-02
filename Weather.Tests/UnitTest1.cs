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
        public void Test1()
        {
            Assert.Equal(_weatherService.Weather, "sunny");
        }
    }
}
