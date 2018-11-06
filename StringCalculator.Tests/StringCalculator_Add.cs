using NUnit.Framework;
using StringCalculator;

namespace StringCalculator.UnitTests.Services
{
    [TestFixture]
    public class Calculator_Add
    {
        private readonly Calculator _calculator;

        public Calculator_Add()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void EmptyStringShouldReturn0()
        {
            var result = _calculator.Add("");

            Assert.AreEqual(result, 0);
        }

        [Test]
        public void StringShouldReturn1()
        {
            var result = _calculator.Add("1");
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void StringShouldReturn3()
        {
            var result = _calculator.Add("1,2");
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void StringShouldreturn6()
        {
            var result = _calculator.Add("1,2,3");
            Assert.AreEqual(result, 6);
        }

        
        [TestCase("1\n,2,3")]
        [TestCase("1,2,3,\n")]
        public void StringAcceptsNewLines(string input)
        {
            var result = _calculator.Add(input);
            Assert.AreEqual(result, 6);
        }


        

    }
}