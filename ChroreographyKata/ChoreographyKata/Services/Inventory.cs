namespace ChoreographyKata.Services
{
    public class Inventory
    {
        private int capacity;
        private Ticketing ticketing;

        public Inventory(int capacity, Ticketing ticketing)
        {
            this.capacity = capacity;
            this.ticketing = ticketing;
        }

        public void DecrementCapacity(int numberOfSeats)
        {
            if (capacity >= numberOfSeats)
            {
                capacity -= numberOfSeats;
                ticketing.printTicket(numberOfSeats);
            }

            Console.WriteLine($"Remaining seats: {capacity}");
        }

        public int RemainingCapacity()
        {
            return this.capacity;
        }
    }
}
