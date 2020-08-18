using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace SeleniumTestProject.Pages
{
    public class PassengerInfoPage : BasePage
    {

        public PassengerInfoPage(IWebDriver driver) : base(driver) { }

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_paxinfo_title']")]
        public IWebElement _paxTitleSelect;

        public SelectElement PaxTitle
        {
            get
            {
                return new SelectElement(_paxTitleSelect);
            }
        }

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_paxinfo_first_name']")]
        public IWebElement FirstNameInput { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_paxinfo_last_name']")]
        public IWebElement LastNameInput { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_trip_form_email']")]
        public IWebElement EmailInput { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_trip_form_confirm_email']")]
        public IWebElement EmailConfirmationInput { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='areaCodeTestId']")]
        public IWebElement AreaCodeInput { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='localNumberTestId']")]
        public IWebElement LocalNumberInput { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_paxinfo_continue']")]
        public IWebElement ContinueBtn { get; private set; }
    }
}
