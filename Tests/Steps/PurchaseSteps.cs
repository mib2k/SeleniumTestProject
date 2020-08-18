using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using static SeleniumTestProject.Tests.WebDriverManager;

namespace SeleniumTestProject.Tests.Steps
{
    class PurchaseSteps : BaseSteps
    {
        PurchasePage _purchasePage;
        public PurchaseSteps() : base()
        {
            _purchasePage = new PurchasePage(Driver);
        }
    }
}
