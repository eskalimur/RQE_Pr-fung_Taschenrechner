using System;
using TechTalk.SpecFlow;
using Xunit;

namespace RQE_Prüfung_Taschenrechner
{
    [Binding]
    public class TrigonometrischerTaschenrechnerSteps
    {
        double number, sum;

        [Given(@"a (.*)")]
        public void GivenA(string p0)
        {
            if (p0 == "PI")
                this.number = Math.PI;
            else
                this.number = 0;
        }

        [When(@"i want to know the Sinus")]
        public void WhenIWantToKnowTheSinus()
        {
            sum = Math.Sin(this.number);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double p0)
        {
            double expected = p0;
            double actual = this.sum;
            Assert.Equal(expected, actual, 5);
        }

        [When(@"i want to know the Cosinus")]
        public void WhenIWantToKnowTheCosinus()
        {
            sum = Math.Cos(this.number);
        }

        [When(@"i want to know the Tangens")]
        public void WhenIWantToKnowTheTangens()
        {
            sum = Math.Tan(this.number);
        }

    }
}
