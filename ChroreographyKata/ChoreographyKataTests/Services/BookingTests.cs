using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChoreographyKata.Services.Tests
{
    [TestClass]
    public class BookingTests
    {
        [TestMethod]
        public void BookTest()
        {
            var t = new Ticketing();
            var i = new Inventory(10, t);

            var b = new Booking(i);

            b.Book(2);

            Assert.AreEqual(8, i.RemainingCapacity());
        }
    }
}