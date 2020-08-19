using SeleniumTestProject.Pages;
using SeleniumTestProject.Tests.Steps;

namespace SeleniumTestProject.Tests
{
    class SeatSelectionSteps : BaseSteps
    {
        SeatSelectionPage _seatSelectionPage => new SeatSelectionPage();

        public void SkipSeatSelection()
        {
            _seatSelectionPage.SkipSeatSelectionBtn.Click();
            _seatSelectionPage.ConfirmNoSeats.Click();
        }
    }
}
