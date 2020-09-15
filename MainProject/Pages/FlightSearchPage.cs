using OpenQA.Selenium;
using System.Collections.Generic;

using static SeleniumTestProject.Utils.WebDriverManager;

namespace SeleniumTestProject.Pages
{
    public class FlightSearchPage : BasePage
    {
        public IWebElement FlightSearchContainer =>
            Driver.FindElement(By.XPath("//*[@data-test-id='test_fsrp_content']"));

        public IList<IWebElement> FareRows => 
            Driver.FindElements(By.XPath("//*[contains(@data-test-id, 'test_row_')]"));

    }
}