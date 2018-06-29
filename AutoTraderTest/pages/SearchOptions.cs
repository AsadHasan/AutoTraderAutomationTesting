using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace AutoTraderTest.pages
{
    class SearchOptions : BasePage
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.CssSelector, Using = ".bigger-body-type-container>li>label>div>.body-type__name")]
        private IList<IWebElement> searchCategories;

        public SearchOptions(IWebDriver webDriver)
            : base(webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(this.webDriver, this);
        }

        public IList<IWebElement> SearchCategories { get => searchCategories; }
    }
}
