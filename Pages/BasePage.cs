using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumTestProject.Tests;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestProject.Pages
{
    public class BasePage
    {
        protected IWebDriver _driver;


        protected BasePage()
        {
            PageFactory.InitElements(WebDriverManager.Driver, this);

        }

        protected BasePage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(_driver, this);
        }
    }
}
