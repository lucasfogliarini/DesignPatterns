namespace DesignPatterns.Behavioral.Observer
{
    public class WindowDisplay(string displayId) : DeviceDisplay(displayId), ISubscriber
    {
    }
}
