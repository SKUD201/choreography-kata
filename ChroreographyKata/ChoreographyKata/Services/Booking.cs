using ChoreographyKata.Messaging;

namespace ChoreographyKata.Services
{
    public class Booking : IListener
    {
        private readonly MessageBus _messageBus;

        public Booking(MessageBus messageBus)
        {
            _messageBus = messageBus;
            _messageBus.Subscribe(this);
        }

        public void Book(int numberOfSeats)
        {
            _messageBus.Send(new Event { Name = "BookingRequested", Payload = numberOfSeats });

            Console.WriteLine($"booking requested: {numberOfSeats}");
        }

        public void OnMessage(object msg)
        {
        }
    }
}
