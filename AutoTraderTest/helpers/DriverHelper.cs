using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Configuration;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace AutoTraderTest.helpers
{
    class DriverHelper
    {
        private static IWebDriver webdriver;

        public static IWebDriver GetWebDriver()
        {
            var browser = ConfigurationManager.AppSettings["browser"];
            if (webdriver == null)
            {
                switch (browser)
                {
                    case "chrome":
                        new DriverManager().SetUpDriver(new ChromeConfig());
                        webdriver = new ChromeDriver();
                        break;
                    case "ie":
                        new DriverManager().SetUpDriver(new InternetExplorerConfig());
                        webdriver = new InternetExplorerDriver();
                        break;
                    case "edge":
                        new DriverManager().SetUpDriver(new EdgeConfig());
                        webdriver = new EdgeDriver();
                        break;
                    case "firefox":
                        new DriverManager().SetUpDriver(new FirefoxConfig());
                        webdriver = new FirefoxDriver();
                        break;
                    default:
                        throw new NotSupportedException("Browser not supported");
                }
            }
            return webdriver;
        }
    }
}
