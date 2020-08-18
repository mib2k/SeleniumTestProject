using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumTestProject.Pages;
using SeleniumTestProject.Tests;
using SeleniumTestProject.Tests.Steps;
using System;
using System.Linq;

namespace SeleniumTestProject
{
    [TestFixture]
    public class MakeFlowTest : BaseTest
    {
        [Test]
        public void SimpleTest()
        {
            LandingPageSteps landingSteps = new LandingPageSteps();

            landingSteps.AcceptCookiesAndLocation();
            landingSteps.SelectOneWayTrip();
            landingSteps.SetAirports("DUB", "LHR");
            landingSteps.SetDates(DateTime.Now.AddDays(3));

            landingSteps.Search();

        }
    }
}