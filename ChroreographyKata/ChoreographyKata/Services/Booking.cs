namespace ChoreographyKata.Services
{
    public class Booking
    {
        private readonly Inventory inventory;

        public Booking(Inventory inventory)
        {
            this.inventory = inventory;
        }

        public void Book(int numberOfSeats)
        {
            inventory.DecrementCapacity(numberOfSeats);

            Console.WriteLine($"booking requested: {numberOfSeats}");
        }
    }
}
