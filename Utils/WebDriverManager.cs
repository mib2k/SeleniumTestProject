using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.ComponentModel;
using System.Threading;

namespace SeleniumTestProject.Tests
{
    public class WebDriverManager
    {
        private static ThreadLocal<IWebDriver> driverPool = new ThreadLocal<IWebDriver>();

        public static IWebDriver Driver => driverPool.Value ??= Instance();

        public static void CloseDriver()
        {
            if (driverPool.IsValueCreated)
            {
                driverPool.Value.Close();
                driverPool.Value.Quit();
                driverPool.Value = null;
            }
        }

        private static IWebDriver Instance() => new ChromeDriver();
    }
}