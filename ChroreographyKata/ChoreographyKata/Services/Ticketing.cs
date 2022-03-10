using ChoreographyKata.Messaging;

namespace ChoreographyKata.Services
{
    public class Ticketing : IListener
    {
        private readonly MessageBus _messageBus;

        public Ticketing(MessageBus messageBus)
        {
            _messageBus = messageBus;
            _messageBus.Subscribe(this);
        }

        public void OnMessage(object msg)
        {
            if (msg is Event receivedEvent && receivedEvent.Name == "BookingReserved")
            {
                PrintTicket(receivedEvent.Payload);
            }
        }

        public void PrintTicket(int numberOfSeats)
        {
            _messageBus.Send(new Event { Name = "TicketsPrinted", Payload = numberOfSeats });
            Console.WriteLine($"Tickets printed: {numberOfSeats}");
        }
    }
}
