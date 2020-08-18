using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumTestProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static SeleniumTestProject.Tests.WebDriverManager;


namespace SeleniumTestProject.Tests.Steps
{
    class LandingPageSteps : BaseSteps
    {
        private LandingPage _landingPage;

        public LandingPageSteps() : base()
        {
            _landingPage = new LandingPage();
        }

        public void AcceptCookiesAndLocation()
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(10)).Until(d => _landingPage.AcceptCookies.Displayed);
            _landingPage.AcceptCookies.Click();
            _landingPage.ConfirmLocaleBtn.Click();
        }

        public void SelectOneWayTrip()
        {
            _landingPage.OneWayRadio.Click();
        }
        public void SetAirports(string From, string To)
        {
            _landingPage.OriginInput.Click();
            _landingPage.OriginInput.SendKeys(From);
            _landingPage.OriginInput.SendKeys(Keys.Enter);

            _landingPage.DestinationInput.Click();
            _landingPage.DestinationInput.SendKeys(To);
            _landingPage.DestinationInput.SendKeys(Keys.Enter);
        }

        public void SetDates(DateTime DateFrom, DateTime? DateTo = null)
        {
            _landingPage.PickerOutboundDateInput.Click();
            IList<IWebElement> daysColletion = _landingPage.PickerCalendar.FindElements(
                By.XPath(".//*[contains(@class, 'ui-state-default') and(not(ancestor::*[contains(@class, 'ui-datepicker-unselectable')]))]")).ToList();

            IWebElement DayFrom = daysColletion.Where(e => e.Text == DateFrom.Day.ToString()).First();
            DayFrom.Click();
            if (DateTo != null)
            {
                IWebElement DayTo = daysColletion.Where(e => e.Text == DateTo?.Day.ToString()).First();
                DayTo.Click();
            }
        }

        public FlightSearchPage Search()
        {
            _landingPage.SearchFlightsButton.Click();
            return new FlightSearchPage(Driver);
        }
    }
}
