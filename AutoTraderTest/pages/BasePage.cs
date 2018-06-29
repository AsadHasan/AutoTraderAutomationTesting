using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;

namespace AutoTraderTest.pages
{
    class BasePage
    {
        private IWebDriver webDriver;
        private WebDriverWait webDriverWait; 

        public BasePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        private WebDriverWait GetWait() {
            return new WebDriverWait(webDriver, TimeSpan.FromSeconds(Convert.ToInt16(ConfigurationManager.AppSettings["timeout"])));
        } 

        protected void clickWhenReady(IWebElement webElement)
        {
            GetWait().Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(webElement));
            webElement.Click();
        }
    }
}
