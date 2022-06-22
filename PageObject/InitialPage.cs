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
    class InitialPage : BasePage
    {
        public InitialPage(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }

        private readonly string ShopMenButton = "splash_gender_shop_men";
        private readonly string NoToNotificationsButton = "splash_push_let_me_consider";
        private readonly string ConfirmLocationButton = "button_positive";

        [AllureStep("Selected gender")]
        public InitialPage ClickOnShopMenButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By
                        .Id(ShopMenButton)));
            driver.FindElementById(ShopMenButton).Click();
            return this;
        }

        [AllureStep("Denied access to notifications")]
        public InitialPage SayNoToNotifications()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By
                        .Id(NoToNotificationsButton)));
            driver.FindElementById(NoToNotificationsButton).Click();
            return this;
        }

        [AllureStep("Confirmed location and currency")]
        public InitialPage ConfirmLocationAndCurrency()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By
                        .Id(ConfirmLocationButton)));
            driver.FindElementById(ConfirmLocationButton).Click();
            return this;
        }
    }
}
