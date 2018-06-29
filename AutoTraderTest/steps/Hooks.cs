using AutoTraderTest.helpers;
using TechTalk.SpecFlow;

namespace AutoTraderTest.steps
{
    [Binding]
    class Hooks
    {
        [After]
        public void CloseBrowser()
        {
            DriverHelper.GetWebDriver().Quit();
        }
    }
}
