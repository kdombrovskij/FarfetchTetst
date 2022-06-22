using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Text;
using FarfetchTetst.Capabilities;

namespace FarfetchTetst.Driver
{
    class AndroidDriver
    {
        private static AndroidDriver<AndroidElement> driver;

        public static AndroidDriver<AndroidElement> getDriver()
        {
            if (driver == null)
            {
                driver = new AndroidDriver<AndroidElement>(Capabilities.Capabilities.getAppiumServerUri(), Capabilities.Capabilities.getCapabilities());
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            }
            return driver;
        }
        public static void quitDriver()
        {
            driver.Quit();
        }
    }
}
