using ChoreographyKata.Services;

namespace ChoreographyKata.Workflow
{
    public class BookingWorkflow
    {
        private readonly Inventory inventory;
        private readonly Ticketing ticketing;
        private readonly Notification notification;

        public BookingWorkflow(Inventory inventory, Ticketing ticketing, Notification notification)
        {
            this.inventory = inventory;
            this.ticketing = ticketing;
            this.notification = notification;
        }

        public void Book(int numberOfSeats)
        {
            var decreased = inventory.DecrementCapacity(numberOfSeats);

            if (decreased)
            {
                ticketing.PrintTicket(numberOfSeats);
            }
            else
            {
                //notification.SendNotEnoughSeats();
            }
        }
    }
}
