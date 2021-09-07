using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using CalculatorLib;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorTests
{
    [Binding]
    public class CalculatorFeatureFileSteps
    {
        private Calculator _calculator;
        private int _result;
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }
        
        [Given(@"I enter (.*) and (.*) into the calculator")]
        public void GivenIEnterAndIntoTheCalculator(int a, int b)
        {
            _calculator.Num1 = a;
            _calculator.Num2 = b;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add();
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            _result = _calculator.Subtract();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            _result = _calculator.Multiply();
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            _result = _calculator.Divide();
        }

        [Then(@"a DivideByZero Exception should be thrown with the exception message ""(.*)"" when I press divide")]
        public void ThenADivideByZeroExceptionShouldBeThrownWithTheExceptionMessageWhenIPressDivide(string result)
        {
            Assert.That(() => _calculator.Divide(), Throws.TypeOf<ArgumentException>().With.Message.EqualTo(result));
        }

        [Given(@"I enter the numbers below to a list")]
        public void GivenIEnterTheNumbersBelowToAList(Table table)
        {
            var result = table.Rows.Select(x => x.FirstOrDefault().Value).ToList();
            _calculator.AddToList(result);
            
        }

        [When(@"I iterate through the list to add all the even numbers")]
        public void WhenIIterateThroughTheListToAddAllTheEvenNumbers()
        {
            int result = _calculator.GetSumOfEveneNumbers(); 
            
            Assert.That(result, Is.EqualTo(6));
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.That(_result, Is.EqualTo(result));
        }
    }
}
