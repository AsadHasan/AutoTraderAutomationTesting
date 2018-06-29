using AutoTraderTest.helpers;
using AutoTraderTest.pages;
using TechTalk.SpecFlow;

namespace AutoTraderTest.steps.search
{
    [Binding]
    class Givens
    {
        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            new Homepage(DriverHelper.GetWebDriver()).Open();
        }
    }
}
