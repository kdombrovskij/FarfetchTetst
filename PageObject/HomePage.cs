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
    class HomePage : BasePage
    {
        public HomePage(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }

        private readonly string SearchButton = "bottom_nav_explore";
        private readonly string SearchInputButton = "search_text";
        private readonly string SearchInput = "exploreSearchInput";
        private readonly string SuggestionButton = "ffb_cell_end_icon";

        [AllureStep("Clicked on the search button")]

        public HomePage ClickOnSearchButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By
                        .Id(SearchButton)));
            driver.FindElementById(SearchButton).Click();
            return this;
        }

        [AllureStep("Clicked on the search line")]
        public HomePage ClickOnSearchInput()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By
                        .Id(SearchInputButton)));
            driver.FindElementById(SearchInputButton).Click();
            return this;
        }

        [AllureStep("Entered search text")]
        public HomePage SearchByKeyword(string query)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By
                        .Id(SearchInput)));
            driver.FindElementById(SearchInput).SendKeys(query);
            return this;
        }

        [AllureStep("Clicked on suggestion button")]
        public HomePage ClickOnSuggestionButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By
                        .Id(SuggestionButton)));
            driver.FindElementById(SuggestionButton).Click();
            return this;
        }

    }
}
