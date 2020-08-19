using NUnit.Framework;
using SeleniumTestProject.Tests;
using SeleniumTestProject.Tests.Steps;
using System;

namespace SeleniumTestProject
{
    [TestFixture]
    public class MakeFlowTest : BaseTest
    {
        LandingPageSteps landingSteps;
        FlightSearchSteps flightSearchSteps;
        SeatSelectionSteps seatSelectionSteps;
        PaxInfoSteps paxInfo;
        TravelEssentialsSteps travelEssentialsSteps;
        TravelExtrasSteps travelExtrasSteps;


        [SetUp]
        public void Init()
        {
            landingSteps = new LandingPageSteps();
            flightSearchSteps = new FlightSearchSteps();
            seatSelectionSteps = new SeatSelectionSteps();
            paxInfo = new PaxInfoSteps();
            travelEssentialsSteps = new TravelEssentialsSteps();
            travelExtrasSteps = new TravelExtrasSteps();
        }


        [Test]
        public void SimpleTest()
        {
            landingSteps.AcceptCookiesAndLocation();
            landingSteps.SelectOneWayTrip();
            landingSteps.SetAirports("DUB", "LHR");
            landingSteps.SetDates(DateTime.Now.AddDays(3));

            landingSteps.Search();

            flightSearchSteps.AssertFares();
            flightSearchSteps.SelectFare();

            paxInfo.FillPaxInfo();
            
            seatSelectionSteps.SkipSeatSelection();
            travelEssentialsSteps.ClickContinueBtn();

            travelExtrasSteps.ClickContinueBtn();

        }
    }
}