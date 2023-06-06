using CalculatorApp;

using FluentAssertions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPractice
{
    [TestClass]
    public class AppTest
    {

        [TestMethod]
        public void TestSum()
        {
            int x = 15;
            int y = 5;
            int expectedResult = 20;
            int actualResult = Calculator.Sum(x, y);
            actualResult.Should().Be(expectedResult);
        }

        /**
         *
         */
        [TestMethod]
        public void TestMultiply()
        {
            int x = 3;
            int y = 5;
            int expectedResult = 15;
            int actualResult = Calculator.Multiply(x, y);
            actualResult.Should().Be(expectedResult);
        }

        [TestMethod]
        public void TestMultiplyBy0()
        {
            int x = 3;
            int y = 0;
            int expectedResult = 0;
            int actualResult = Calculator.Multiply(x, y);
            actualResult.Should().Be(expectedResult);
        }

        [TestMethod]
        public void TestDivide()
        {
            float x = 1f;
            float y = 2f;
            float expectedResult = 1f / 2;
            float actualResult = Calculator.divide(x, y);
            actualResult.Should().Be(expectedResult);
        }

        [TestMethod]
        public void TestDivideBy0()
        {
            float x = 3;
            float y = 0;
            int expectedResult = 0;
            float actualResult = Calculator.divide(x, y);
            actualResult.Should().Be(expectedResult);
        }

    }
}
