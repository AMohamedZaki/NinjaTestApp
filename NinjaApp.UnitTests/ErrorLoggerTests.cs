using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace NinjaApp.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {

        [Test]
        public void Log_WhenCalled_LastLogShouldSaveTheLog()
        {
            // Assign 
            var log = new ErrorLogger();

            // Act 
            log.Log("a");

            // Assert

            Assert.That(log.LastError, Is.EqualTo("A").IgnoreCase);

        }
    }
}
