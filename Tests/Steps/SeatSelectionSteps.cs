using OpenQA.Selenium;
using SeleniumTestProject.Pages;
using SeleniumTestProject.Tests.Steps;
using System;
using System.Collections.Generic;
using System.Text;
using static SeleniumTestProject.Tests.WebDriverManager;

namespace SeleniumTestProject.Tests
{
    class SeatSelectionSteps : BaseSteps
    {
        SeatSelectionPage _seatSelectionPage;
        public SeatSelectionSteps() : base()
        {
            _seatSelectionPage = new SeatSelectionPage(Driver);
        }

        public void SkipSeatSelection()
        {
            _seatSelectionPage.SkipSeatSelectionBtn.Click();
        }
    }
}
