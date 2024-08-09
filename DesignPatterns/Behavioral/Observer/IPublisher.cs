namespace DesignPatterns.Behavioral.Observer
{
    public interface IPublisher
    {
        void Subscribe(ISubscriber observer);
        void Unsubscribe(ISubscriber observer);
        void NotifySubscribers();
    }
}
