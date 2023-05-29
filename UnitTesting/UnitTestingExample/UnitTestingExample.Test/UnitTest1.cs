using System;
using UnitTestingExample;
using FluentAssertions;

namespace UnitTestingExample.Test
{
    public class Tests
    {
        private UnitTestingExample.Calculator calc;
        [SetUp]
        public void Setup()
        {
            calc = new UnitTestingExample.Calculator();
        }

        [Test]
        public void Add_WhenCalled_ReturnsSumOfTwoNumbers()
        {
            var res = calc.Add(1, 2);
            Assert.That(res, Is.EqualTo(3));
        }

        [Test]
        public void Sub_WhenCalled_ReturnsDiffOfTwoNumbers()
        {
            var res = calc.Sub(2, 1);
            Assert.That(res, Is.EqualTo(1));
        }

        [Test]
        public void Mul_WhenCalled_ReturnsProductOfTwoNumbers()
        {
            var res = calc.Mul(2, 1);
            Assert.That(res, Is.EqualTo(2));
        }

        [Test]
        public void Div_WhenCalled_ReturnsDivisionOfTwoNumbers()
        {
            var res = calc.Div(2, 1);
            Assert.That(res, Is.EqualTo(2));
        }

        [Test]
        public void Mod_WhenCalled_ReturnsModOfTwoNumbers()
        {
            var res = calc.Mod(2, 1);
            Assert.That(res, Is.EqualTo(0));
        }

        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnsResultBasedOnValue(int a, int b, int expected)
        {
            var result = calc.GreatestNumber(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        //Fluent Assertions
        [Test]
        public void GetOddNumbers_WhenCalled_ReturnsOddNumbersUptoRange()
        {
            Calculator calc = new Calculator();
            var result = calc.GetOddNumbers(10);
            Assert.AreEqual(result.Count(), 5);

            //Fluent Assertions
            result.Should().HaveCount(5);
            result.Should().Contain(1);
            result.Should().Contain(3);
            result.Should().Contain(5);
        }
    }
}