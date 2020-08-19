using SeleniumTestProject.ElementExtensions;

namespace SeleniumTestProject.Tests.Steps
{
    class TravelExtrasSteps : BaseSteps
    {
        TravelExtrasPage _travelExtrasPage => new TravelExtrasPage();

        public void ClickContinueBtn()
        {
            _travelExtrasPage.ContinueBtn.WaitForVisible(60);
            _travelExtrasPage.ContinueBtn.Click();
        }
    }
}
