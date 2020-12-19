using NUnit.Framework;
using TestNinja.Fundamentals;

namespace NinjaApp.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanBeCancelledBy_Admin_ResturnTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.IsTrue(result);
        }


        [Test]
        public void CanBeCancelledBy_SameUser_ReturnTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation() {  MadeBy = user };

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.That(result, Is.True);
        }


        [Test]
        public void CanBeCancelledBy_AnotherUser_ReturnFalse()
        {
            // Arrange
            var reservation = new Reservation() { MadeBy = new User() };

            // Act
            var result = reservation.CanBeCancelledBy(new User());

            // Assert
            Assert.IsFalse(result);
        }
    }
}