using ChoreographyKata.Messaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChoreographyKata.Services.Tests
{
    [TestClass]
    public class BookingTests
    {
        [TestMethod]
        public void Book_NominalCase()
        {
            var ms = new MessageBus();

            new Ticketing(ms);
            new Notification(ms);
            var i = new Inventory(10, ms);

            var b = new Booking(ms);

            b.Book(2);

            Assert.AreEqual(8, i.RemainingCapacity());
        }

        [TestMethod]
        public void Book_NotEnoughSeats()
        {
            var ms = new MessageBus();

            new Ticketing(ms);
            new Notification(ms);
            var i = new Inventory(10, ms);

            var b = new Booking(ms);

            b.Book(12);

            Assert.AreEqual(10, i.RemainingCapacity());
        }
    }
}