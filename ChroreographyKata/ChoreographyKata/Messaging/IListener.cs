namespace ChoreographyKata.Messaging
{
    public interface IListener
    {
        void OnMessage(Object msg);
    }
}
