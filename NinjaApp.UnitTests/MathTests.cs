using NUnit.Framework;
using TestNinja.Fundamentals;
using System.Linq;

namespace NinjaApp.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;
        [SetUp]
        public void Setup()
        {
            _math = new Math();
        }

        [Test]
        [Ignore("Because I Want to")]
        public void Add_WhenCall_ReturnTheSumArguments()
        {
            var result = _math.Add(2, 1);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheBiggerArgument(int firstArgument, int secondArgument, int ExcepectedValue)
        {
            var result = _math.Max(firstArgument, secondArgument);

            Assert.That(result, Is.EqualTo(ExcepectedValue));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            // in general 
            // Assert.That(result.Count(), Is.EqualTo(3));
            //Assert.That(result., Is.Not.Empty);

            // More Specific
            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            // For Checking order
            //Assert.That(result, Is.Ordered);
            //Assert.That(result, Is.Unique);

            Assert.That(result, Is.EquivalentTo(new int[] { 1, 3, 5 }));
        }
    }
}
