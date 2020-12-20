using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace NinjaApp.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {

        [Test]
        public void Getoutput_InputDivisableBy3_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(3);
            Assert.That(result, Is.EqualTo("Fizz"));
        }
        
        [Test]
        public void Getoutput_InputDivisableBy5_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(5);
            Assert.That(result, Is.EqualTo("Buzz"));
        }
        
        
        
        [Test]
        public void Getoutput_InputNotDivisableBy3Or5_ReturnSameNumber()
        {
            var result = FizzBuzz.GetOutput(1);
            Assert.That(result, Is.EqualTo("1"));
        }    
        
        [Test]
        public void Getoutput_InputDivisableBy3Or5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
    }
}
