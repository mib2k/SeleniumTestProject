using OpenQA.Selenium;
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
            _travelEssentialsPage = new TravelEssentialsPage(Driver);
        }

        public void ClickContinueBtn()
        {
            _travelEssentialsPage.ContinueBtn.Click();
        }

    }
}
