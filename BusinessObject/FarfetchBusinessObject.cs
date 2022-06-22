using FarfetchTetst.PageObject;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarfetchTetst.BusinessObject
{
    class FarfetchBusinessObject
    {
        private readonly InitialPage initialPage;
        private readonly HomePage homePage;
        private readonly SearchResultPage searchResultPage;
        private readonly WishlistPage wishlistPage;
        private readonly ProductPage productPage;
        private readonly BagPage bagPage;

        public FarfetchBusinessObject(AppiumDriver<AndroidElement> driver)
        {
            initialPage = new InitialPage(driver);
            homePage = new HomePage(driver);
            searchResultPage = new SearchResultPage(driver);
            wishlistPage = new WishlistPage(driver);
            productPage = new ProductPage(driver);
            bagPage = new BagPage(driver);
        }

        public FarfetchBusinessObject SkipInitialPages()
        {
            initialPage.ClickOnShopMenButton().SayNoToNotifications().ConfirmLocationAndCurrency();
            return this;
        }

        public FarfetchBusinessObject MakeSearch(string query)
        {
            homePage.ClickOnSearchButton().ClickOnSearchInput().SearchByKeyword(query).ClickOnSuggestionButton();
            return this;
        }

        public string GetProductName()
        {
            return searchResultPage.GetProductDescription();
        }

        public FarfetchBusinessObject AddItemToWishList()
        {
            searchResultPage.AddToWishlist().ClickWishlistButton();
            return this;
        }

        public string GetWishlistHeader()
        {
            return wishlistPage.GetNumberOfItemsInWishlist();
        }

        public FarfetchBusinessObject ClickOnProduct()
        {
            searchResultPage.ClickOnProduct();
            return this;
        }

        public FarfetchBusinessObject AddToCart()
        {
            productPage.ClickOnAddToBagButton();
            return this;
        }

        public FarfetchBusinessObject ClickGoToBag()
        {
            productPage.ClickOnGoToBagButton();
            return this;
        }

        public string GetBagCounter()
        {
            return bagPage.GetBagCounter();
        }
    }
}
