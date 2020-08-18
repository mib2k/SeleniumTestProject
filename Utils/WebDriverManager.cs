using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

using System.Threading;

namespace SeleniumTestProject.Tests
{
    public class WebDriverManager
    {
        private static ThreadLocal<IWebDriver> driverPool = new ThreadLocal<IWebDriver>();

        public static IWebDriver Driver
        {
            get
            {
                var _driver = driverPool.Value ??= Instance();
                Thread.Sleep(300);
                return _driver;
            }
            private set { }
        }


        public static void CloseDriver()
        {
            if (driverPool.IsValueCreated)
            {
                driverPool.Value.Close();
                driverPool.Value.Quit();
                driverPool.Value = null;
            }
        }


        public static void WaitForVisible(int TimeToWait, IWebElement element)
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(TimeToWait)).Until(d => element.Displayed && element.Enabled);
        }

        public static void WaitForClickable(int TimeToWait, IWebElement element)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(TimeToWait));
            wait.Until(driver => element.Displayed && element.Enabled);
            wait.Until(driver => SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        private static IWebDriver Instance()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);

            return driver;
        }
    }
}