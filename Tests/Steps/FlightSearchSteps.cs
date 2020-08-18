using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SeleniumTestProject.Pages;
using System;
using System.Linq;
using System.Text;

using static SeleniumTestProject.Tests.WebDriverManager;

namespace SeleniumTestProject.Tests.Steps
{
    class FlightSearchSteps : BaseSteps
    {
        private FlightSearchPage _flightSearchPage;

        public FlightSearchSteps() : base()
        {
            _flightSearchPage = new FlightSearchPage();
        }

        public void AssertFares()
        {
            Assert.IsTrue(_flightSearchPage.FareRows.Count > 0, "No fares found");
        }

        public void SelectFare(double? price = null)
        {
            var FirstAvailableFare = _flightSearchPage.FareRows.First();

            //Selecting flight
            FirstAvailableFare.FindElement(By.XPath(".//*[contains(@data-test-id, 'test_fare_category')]")).Click();

            //Selecting fare
            IWebElement fare = FirstAvailableFare.FindElement(By.XPath(".//*[contains(@data-test-id, 'test_fare_button_') and not(@disabled)]"));
            WaitForVisible(3, fare);
            fare.Click();

            //Proceed to next page
            IWebElement continueBtn = _flightSearchPage.FlightSearchContainer.FindElement(By.XPath(".//*[@data-test-id='test_button_continue_fsr']"));
            WaitForVisible(3, continueBtn);

            continueBtn.Click();
        }
    }
}
