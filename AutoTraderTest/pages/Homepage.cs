using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Configuration;

namespace AutoTraderTest.pages
{
    class Homepage:BasePage
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.CssSelector, Using = "[data-label='more options']")]
        private IWebElement moreOptionsButton;

        public Homepage(IWebDriver webDriver)
            :base(webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(this.webDriver, this);
        }
        public Homepage Open()
        {
            webDriver.Navigate().GoToUrl(ConfigurationManager.AppSettings["baseurl"]);
            return this;
        }

        public SearchOptions chooseMoreOptions()
        {
            clickWhenReady(moreOptionsButton);
            return new SearchOptions(webDriver);
        }
    }
}
