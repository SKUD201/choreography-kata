namespace ChoreographyKata.Messaging
{
    public class MessageBus
    {
        private List<IListener> subscriptions = new List<IListener>();

        public void Subscribe(IListener l)
        {
            this.subscriptions.Add(l);
        }

        public void Send(Object msg)
        {
            foreach (var l in subscriptions)
            {
                l.OnMessage(msg);
            }
        }
    }
}
