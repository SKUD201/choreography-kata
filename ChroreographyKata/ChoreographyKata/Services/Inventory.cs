namespace ChoreographyKata.Services
{
    public class Inventory
    {
        private int capacity;

        public Inventory(int capacity)
        {
            this.capacity = capacity;
        }

        public bool DecrementCapacity(int numberOfSeats)
        {
            if (capacity >= numberOfSeats)
            {
                capacity -= numberOfSeats;
                Console.WriteLine($"Remaining seats: {capacity}");

                return true;
            }

            Console.WriteLine($"Not enought seats ! (current: {capacity}");
            return false;
        }

        public int RemainingCapacity()
        {
            return this.capacity;
        }
    }
}
