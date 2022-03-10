using ChoreographyKata.Workflow;

namespace ChoreographyKata.Services
{
    public class Booking
    {
        private readonly BookingWorkflow workflow;

        public Booking(BookingWorkflow workflow)
        {
            this.workflow = workflow;
        }

        public void Book(int numberOfSeats)
        {
            workflow.Book(numberOfSeats);

            Console.WriteLine($"booking requested: {numberOfSeats}");
        }
    }
}
