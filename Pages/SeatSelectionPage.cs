
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTestProject.Pages
{
    public class SeatSelectionPage : BasePage
    {
        public SeatSelectionPage(IWebDriver driver) : base(driver) { }
        

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_btn_skip_seat_selection']")]
        public IWebElement SkipSeatSelectionBtn { get; private set; }
    }
}