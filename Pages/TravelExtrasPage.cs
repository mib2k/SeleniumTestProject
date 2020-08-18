using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumTestProject.Pages;
using SeleniumTestProject.Tests;

namespace SeleniumTestProject
{
    public class TravelExtrasPage : BasePage
    {


        public TravelExtrasPage() : base() { }

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_button_continue_extras']")]
        public IWebElement ContinueBtn
        {
            get; private set;
        }
    }
}