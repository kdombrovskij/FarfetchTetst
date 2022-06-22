
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
    class ProductPage : BasePage
    {
        public ProductPage(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }

        private readonly string AddToBagButton = "addToBagButton";
        private readonly string GoToBagPopup = "bottomSheetAddToBagButton";


        [AllureStep("Added product to bag")]
        public ProductPage ClickOnAddToBagButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By
                        .Id(AddToBagButton)));
            driver.FindElementById(AddToBagButton).Click();
            return this;
        }

        [AllureStep("Clicked on the bag button")]
        public ProductPage ClickOnGoToBagButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By
                        .Id(GoToBagPopup)));
            driver.FindElementById(GoToBagPopup).Click();
            return this;
        }
    }
}
