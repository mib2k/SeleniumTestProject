using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

using static SeleniumTestProject.Utils.WebDriverManager;

namespace SeleniumTestProject.Pages
{
    public class FlightSearchPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_fsrp_content']")]
        public IWebElement FlightSearchContainer { get; private set; }

        public IList<IWebElement> FareRows => 
            Driver.FindElements(By.XPath("//*[contains(@data-test-id, 'test_row_')]"));

    }
}