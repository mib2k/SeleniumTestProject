using SeleniumTestProject.Pages;
using SeleniumTestProject.Steps;

namespace SeleniumTestProject.Steps

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
