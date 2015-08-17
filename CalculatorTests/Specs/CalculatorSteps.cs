using CalculatorExample;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CalculatorTests.Specs
{
    [Binding]
    public class CalculatorSteps
    {
        public Calculator calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.Add(number);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            calculator.Sum();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(calculator.Sum(), expectedResult);
        }
    }
}
