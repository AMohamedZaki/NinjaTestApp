using NUnit.Framework;
using TestNinja.Fundamentals;

namespace NinjaApp.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldElcosedWithTheString()
        {
            var format = new HtmlFormatter();

            var result = format.FormatAsBold("abc");

            // Specific
            // Assert.That(result, Is.EqualTo("<strong>abc</strong>"));
            
            // in General
            Assert.That(result, Does.StartWith("<strong>") );
            Assert.That(result, Does.Contain("abc") );
            Assert.That(result, Does.EndWith("</strong>") );

        }

    }
}
