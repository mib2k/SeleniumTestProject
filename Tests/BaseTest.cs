using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestProject.Tests
{
   public class BaseTest
    {
        protected IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = WebDriverManager.Driver;
            driver.Url = "https://www-devk1.aerlingus.com";
        }

        [OneTimeTearDown]
        public void ShutDown()
        {
            WebDriverManager.CloseDriver();
        }
    }
}
