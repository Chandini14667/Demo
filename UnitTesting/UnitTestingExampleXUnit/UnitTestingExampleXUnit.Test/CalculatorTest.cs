using UnitTestingExampleXUnit;
using FluentAssertions;

namespace UnitTestingExampleXUnit.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Add_WhenCalled_ReturnsSumOfTwoNumbers()
        {
            Calculator calc = new Calculator();
            var res = calc.Add(1, 2);
            Assert.Equal(3, res);
        }

        [Fact]
        public void Sub_WhenCalled_ReturnsDiffOfTwoNumbers()
        {
            Calculator calc = new Calculator();
            var res = calc.Sub(2, 1);
            Assert.Equal(1, res);
        }

        [Fact]
        public void Mul_WhenCalled_ReturnsProductOfTwoNumbers()
        {
            Calculator calc = new Calculator();
            var res = calc.Mul(1, 2);
            Assert.Equal(2, res);
        }

        [Fact]
        public void Div_WhenCalled_ReturnsDivisonOfTwoNumbers()
        {
            Calculator calc = new Calculator();
            var res = calc.Div(2, 1);
            Assert.Equal(2, res);
        }

        [Fact]
        public void Mod_WhenCalled_ReturnsModulusOfTwoNumbers()
        {
            Calculator calc = new Calculator();
            var res = calc.Mod(2, 1);
            Assert.Equal(0, res);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(1, 2, 2)]
        [InlineData(2, 2, 2)]
        public void Max_WhenCalled_ReturnsValueBasedOnInput(int a, int b, int expected)
        {
            Calculator calc = new Calculator();
            var res = calc.GreatestNumber(a, b);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void GetOddNumbers_WhenCalled_ReturnsOddNumbersUptoRange()
        {
            Calculator calc = new Calculator();
            var result = calc.GetOddNumbers(10);
            Assert.Equal(result.Count(), 5);
            Assert.IsAssignableFrom<IEnumerable<int>>(result);

            //Fluent Assertions
            result.Should().HaveCount(5);
            result.Should().Contain(1);
            result.Should().Contain(3);
            result.Should().Contain(5);
        }
    }
}