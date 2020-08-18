using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTestProject.Pages;
using System;
using System.Collections.Generic;
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
            _flightSearchPage = new FlightSearchPage(Driver);
        }

        public void AssertFares() {
            Assert.IsTrue(_flightSearchPage.FareRows.Count > 0, "No fares found");
        }

        public PassengerInfoPage SelectFare(double? price = null)
        {
            var FirstAvailableFare = _flightSearchPage.FareRows.First();

            //Selecting flight
            FirstAvailableFare.FindElement(By.XPath(".//*[contains(@data-test-id, 'test_fare_category')]")).Click();

            //Selecting fare
            FirstAvailableFare.FindElement(By.XPath(".//*[contains(@data-test-id, 'test_fare_button_') and not(@disabled)]")).Click();

            //Proceed to next page
            _flightSearchPage.FlightSearchContainer.FindElement(By.XPath(".//*[@data-test-id='test_button_continue_fsr']")).Click();
            return new PassengerInfoPage(Driver);
        }
    }
}
