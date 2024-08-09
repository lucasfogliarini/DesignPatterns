namespace DesignPatterns.Behavioral.Observer
{
    public class WeatherStationPublisherUnitTests
    {
        [Fact]
        public void SetTemperature_ShouldNotify_WhenIsSubscribed()
        {
            var firstTemperature = 25.0f;
            var secondTemperature = 28.3f;
            var weatherStation = new WeatherStationPublisher();

            var phoneDisplay1 = new PhoneDisplay("1");
            var phoneDisplay2 = new PhoneDisplay("2");
            var windowDisplay = new WindowDisplay("A");

            weatherStation.Subscribe(phoneDisplay1);
            weatherStation.Subscribe(phoneDisplay2);
            weatherStation.Subscribe(windowDisplay);

            weatherStation.SetTemperature(firstTemperature);

            // Remove a phone display and update the temperature again
            weatherStation.Unsubscribe(phoneDisplay1);
            weatherStation.SetTemperature(secondTemperature);

            Assert.Equal(phoneDisplay1.Temperature, firstTemperature);
            Assert.Equal(phoneDisplay2.Temperature, secondTemperature);
            Assert.Equal(windowDisplay.Temperature, secondTemperature);
        }
    }
}