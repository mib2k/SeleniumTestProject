using SeleniumTestProject.ElementExtensions;
using SeleniumTestProject.Pages;

namespace SeleniumTestProject.Tests.Steps
{
    class TravelEssentialsSteps : BaseSteps
    {
        TravelEssentialsPage _travelEssentialsPage => new TravelEssentialsPage();

        public void ClickContinueBtn()
        {
            _travelEssentialsPage.ContinueBtn.WaitForVisible(10);
            _travelEssentialsPage.ContinueBtn.Click();

            _travelEssentialsPage.ConfirmNoBags.WaitForVisible(10);
            _travelEssentialsPage.ConfirmNoBags.Click();
        }
    }
}
