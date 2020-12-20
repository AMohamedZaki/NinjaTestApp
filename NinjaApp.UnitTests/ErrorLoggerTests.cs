using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace NinjaApp.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger _log;
        
        [SetUp]
        public void setup()
        {
            _log = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_LastLogShouldSaveTheLog()
        {
            // Act 
            _log.Log("a");

            // Assert
            Assert.That(_log.LastError, Is.EqualTo("A").IgnoreCase);
        }
        
        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_EmptyErrorParameter_ReturnArgumentNullException(string error)
        {
            // Assert
            Assert.That(() => _log.Log(error), Throws.ArgumentNullException);

            // Another Type of Exceptions
            // TypeOf for the Type of class
            // instance of for type of class or derivative of class
            // Assert.That(() => _log.Log(error), Throws.Exception.TypeOf<CustomException>);
        }


        [Test]
        public void Log_ValidError_RaiseTheEvent()
        {
            // Assign
            var id = Guid.Empty;

            // Subscribe to the event 
            _log.ErrorLogged += (sender, args) => { id = args; };

            // Call void Method
            _log.Log("e");

            // Assert
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
