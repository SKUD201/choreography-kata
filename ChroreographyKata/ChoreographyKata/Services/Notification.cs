using ChoreographyKata.Messaging;

namespace ChoreographyKata.Services
{
    public class Notification : IListener
    {
        public Notification(MessageBus messageBus)
        {
            messageBus.Subscribe(this);
        }

        public void OnMessage(object msg)
        {
            if (msg is Event receivedEvent && receivedEvent.Name == "NotEnoughCapacity")
            {
                SendNotEnoughSeats();
            }
        }

        public void SendNotEnoughSeats()
        {
            Console.WriteLine("Not enought seats bro, lose some friends");
        }
    }
}
