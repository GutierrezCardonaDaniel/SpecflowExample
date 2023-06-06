using CalculatorApp;

using FluentAssertions;

using TechTalk.SpecFlow;

namespace TestPractice.Steps
{
    [Binding]
    public class multiplyStepDefinitions
    {

        private int x;
        private int y;
        private int actualResult;

        [Given("the first number is (.*)")]
        public void theFirstNumberIs(int number)
        {
            this.x = number;
        }

        [Given("the second number is (.*)")]
        public void theSecondNumberIs(int number)
        {
            this.y = number;
        }

        [When("the calculator multiplies both numbers")]
        public void theCalculatorMultipliesBothNumbers()
        {
            actualResult = Calculator.Multiply(x, y);
        }

        [Then("the resulting value should be (.*)")]
        public void theResultingValueShouldBe(int expectedResult)
        {
            actualResult.Should().Be(expectedResult);
        }
    }
}
