using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

using static SeleniumTestProject.Tests.WebDriverManager;

namespace SeleniumTestProject.Tests.Steps
{
    class TravelExtrasSteps : BaseSteps
    {
        TravelExtrasPage _travelExtrasPage;
        public TravelExtrasSteps() : base()
        {
            _travelExtrasPage = new TravelExtrasPage();
        }

        public void ClickContinueBtn()
        {
            WaitForVisible(60, _travelExtrasPage.ContinueBtn);
            _travelExtrasPage.ContinueBtn.Click();
        }
    }
}
