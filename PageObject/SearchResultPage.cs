using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FarfetchTetst.PageObject
{
    class SearchResultPage : BasePage
    {
        public SearchResultPage(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }
        public string product;
        private readonly string ProductDescription = "//android.view.ViewGroup/android.widget.LinearLayout/android.widget.TextView[1]";
        private readonly string AddToWishlistButton = "(//android.widget.ImageView[@content-desc='icon'])[1]";
        private readonly string WishlistButton = "bottom_nav_wishlist";


        [AllureStep("Got product description")]
        public string GetProductDescription()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By
                        .XPath(ProductDescription)));
            return driver.FindElementByXPath(ProductDescription).Text;
        }

        [AllureStep("Added item to wishlist")]
        public SearchResultPage AddToWishlist()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By
                        .XPath(AddToWishlistButton)));
            driver.FindElementByXPath(AddToWishlistButton).Click();
            return this;
        }

        [AllureStep("Clicked on the wishlist button")]
        public SearchResultPage ClickWishlistButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.FindElementById(WishlistButton).Click();
            return this;
        }

        [AllureStep("Clicked on the product")]
        public SearchResultPage ClickOnProduct()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By
                        .XPath(ProductDescription)));
            driver.FindElementByXPath(ProductDescription).Click();
            return this;
        }
    }
}
