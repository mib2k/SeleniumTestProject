﻿using NUnit.Framework;
using static SeleniumTestProject.Utils.WebDriverManager;

namespace SeleniumTestProject.Tests
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl("https://www-devk1.aerlingus.com");
        }

        [OneTimeTearDown]
        public void ShutDown()
        {
            CloseDriver();
        }
    }
}
