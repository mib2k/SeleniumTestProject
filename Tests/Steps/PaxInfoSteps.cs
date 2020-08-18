using OpenQA.Selenium;
using SeleniumTestProject.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using static SeleniumTestProject.Tests.WebDriverManager;
namespace SeleniumTestProject.Tests.Steps
{
    class PaxInfoSteps : BaseSteps
    {
        private PassengerInfoPage _paxInfoPage;
        public PaxInfoSteps() : base()
        {
            _paxInfoPage = new PassengerInfoPage(Driver);
        }

        public SeatSelectionPage FillPaxInfo()
        {
            _paxInfoPage.PaxTitle.SelectByText("Miss");
            _paxInfoPage.FirstNameInput.SendKeys("Jane");
            _paxInfoPage.LastNameInput.SendKeys("Doe");

            _paxInfoPage.EmailInput.SendKeys("TestMail@tests.com");
            _paxInfoPage.EmailConfirmationInput.SendKeys("TestMail@tests.com");

            _paxInfoPage.AreaCodeInput.SendKeys("11");
            _paxInfoPage.LocalNumberInput.SendKeys("123123123");

            _paxInfoPage.ContinueBtn.Click();
            return new SeatSelectionPage(Driver);
        }
    }
}
