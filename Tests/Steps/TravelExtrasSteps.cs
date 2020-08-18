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
            _travelExtrasPage = new TravelExtrasPage(Driver);
        }

        public void ClickContinueBtn()
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(30)).Until(d => _travelExtrasPage.ContinueBtn);
            _travelExtrasPage.ContinueBtn.Click();
        }
    }
}
