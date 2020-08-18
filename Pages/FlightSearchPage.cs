using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumTestProject.Pages
{
    public class FlightSearchPage : BasePage
    {
        public FlightSearchPage(IWebDriver driver) : base(driver) { }

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_fsrp_content']")]
        public IWebElement FlightSearchContainer { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@data-test-id, 'test_row_')]")]
        public IList<IWebElement> FareRows { get; private set; }
    }
}