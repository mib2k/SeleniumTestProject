using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumTestProject.Pages;
using System;
using System.Collections.Generic;
using System.Text;

using static SeleniumTestProject.Tests.WebDriverManager;

namespace SeleniumTestProject.Tests.Steps
{
    class TravelEssentialsSteps : BaseSteps
    {
        TravelEssentialsPage _travelEssentialsPage;
        public TravelEssentialsSteps() : base()
        {
            _travelEssentialsPage = new TravelEssentialsPage();

        }

        public void ClickContinueBtn()
        {
            WaitForClickable(10, _travelEssentialsPage.ContinueBtn);
            _travelEssentialsPage.ContinueBtn.Click();

            WaitForClickable(10, _travelEssentialsPage.ConfirmNoBags);
            _travelEssentialsPage.ConfirmNoBags.Click();
        }
    }
}
