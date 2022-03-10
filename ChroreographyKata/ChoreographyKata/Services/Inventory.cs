using ChoreographyKata.Messaging;

namespace ChoreographyKata.Services
{
    public class Inventory : IListener
    {
        private readonly MessageBus _messageBus;
        private int capacity;

        public Inventory(int capacity, MessageBus messageBus)
        {
            _messageBus = messageBus;
            _messageBus.Subscribe(this);

            this.capacity = capacity;
        }

        public bool DecrementCapacity(int numberOfSeats)
        {
            if (capacity >= numberOfSeats)
            {
                capacity -= numberOfSeats;
                Console.WriteLine($"Remaining seats: {capacity}");
                _messageBus.Send(new Event { Name = "CapacityDecremented", Payload = numberOfSeats });

                return true;
            }

            Console.WriteLine($"Not enought seats ! (current: {capacity}");
            _messageBus.Send(new Event { Name = "NotEnoughCapacity", Payload = numberOfSeats });

            return false;
        }

        public void OnMessage(object msg)
        {
            if (msg is Event receivedEvent && receivedEvent.Name == "BookingRequested")
            {
                if (DecrementCapacity(receivedEvent.Payload))
                {
                    _messageBus.Send(new Event { Name = "BookingReserved", Payload = receivedEvent.Payload });
                }
            }
        }

        public int RemainingCapacity()
        {
            return this.capacity;
        }
    }
}
