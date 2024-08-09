namespace DesignPatterns.Behavioral.Observer
{
    public abstract class DeviceDisplay(string displayId) : ISubscriber
    {
        public float Temperature { get; set; }
        protected string DisplayId { get; set; } = displayId;

        public void Update(float temperature)
        {
            Temperature = temperature;
            Console.WriteLine($"Phone Display {displayId}: Temperature updated to {temperature}°C");
        }
    }
}
