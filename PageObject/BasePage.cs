using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarfetchTetst.PageObject
{
    class BasePage
    {
        protected AppiumDriver<AndroidElement> driver;

        public BasePage(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }
    }
}
