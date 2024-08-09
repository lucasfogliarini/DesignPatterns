namespace DesignPatterns.Behavioral.Observer
{
    public class WeatherStationPublisher : IPublisher
    {
        private List<ISubscriber> Subscribers { get; set; } = [];
        private float temperature;

        public void Subscribe(ISubscriber observer)
        {
            Subscribers.Add(observer);
        }
        public void Unsubscribe(ISubscriber observer)
        {
            Subscribers.Remove(observer);
        }
        public void NotifySubscribers()
        {
            foreach (var subscriber in Subscribers)
            {
                subscriber.Update(temperature);
            }
        }
        public void SetTemperature(float newTemperature, bool notify = true)
        {
            temperature = newTemperature;
            if(notify)
                NotifySubscribers();
        }
    }
}
