namespace DesignPatterns.Behavioral.Observer
{
    public class PhoneDisplay(string id) : DeviceDisplay(id), ISubscriber 
    {
    }
}
