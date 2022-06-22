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
    class WishlistPage : BasePage
    {
        public WishlistPage(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }

        public string header;
        private readonly string WishlistHeader = "expandedText";

        [AllureStep("Got number of items in the wishlist")]
        public string GetNumberOfItemsInWishlist()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By
                        .Id(WishlistHeader)));
            return driver.FindElementById(WishlistHeader).Text;
        }
    }
}
