using ChoreographyKata.Workflow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChoreographyKata.Services.Tests
{
    [TestClass]
    public class BookingTests
    {
        [TestMethod]
        public void Book_NominalCase()
        {
            var t = new Ticketing();
            var i = new Inventory(10);
            var n = new Notification();
            var bw = new BookingWorkflow(i, t, n);

            var b = new Booking(bw);

            b.Book(2);

            Assert.AreEqual(8, i.RemainingCapacity());
        }

        [TestMethod]
        public void Book_NotEnoughSeats()
        {
            var t = new Ticketing();
            var i = new Inventory(10);
            var n = new Notification();
            var bw = new BookingWorkflow(i, t, n);

            var b = new Booking(bw);

            b.Book(12);

            Assert.AreEqual(10, i.RemainingCapacity());
        }
    }
}