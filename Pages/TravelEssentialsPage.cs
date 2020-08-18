using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestProject.Pages
{
    class TravelEssentialsPage : BasePage
    {

        public TravelEssentialsPage(IWebDriver driver) : base(driver) { }



        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_continue_btn_bags']")]
        public IWebElement ContinueBtn { get; private set; }

    }
}
