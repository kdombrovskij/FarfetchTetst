using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarfetchTetst.PageObject
{
    class BagPage : BasePage
    {
        public BagPage(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }

        private readonly string BagCounter = "expandedText";

        [AllureStep("Got shopping bag counter")]
        public string GetBagCounter()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By
                        .Id(BagCounter)));
            return driver.FindElementById(BagCounter).Text;
        }
    }
}
