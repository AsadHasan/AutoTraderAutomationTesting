using AutoTraderTest.helpers;
using AutoTraderTest.pages;
using TechTalk.SpecFlow;

namespace AutoTraderTest.steps.search
{
    [Binding]
    class Whens
    {
        [When(@"I choose More Options")]
        public void WhenIChooseMoreOptions()
        {
            new Homepage(DriverHelper.GetWebDriver()).chooseMoreOptions();
        }
    }
}
