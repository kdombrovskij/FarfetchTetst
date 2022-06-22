using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using System;
using FarfetchTetst.PageObject;
using FarfetchTetst.BusinessObject;
using FarfetchTetst.Driver;
using OpenQA.Selenium.Interactions;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;

namespace FarfetchTetst
{

    [TestFixture]
    [AllureNUnit]
    [AllureSuite("Farfetch app tests")]
    [AllureDisplayIgnored]

    public class BaseTest
    {
        private FarfetchBusinessObject farfetchBusinessObject;
        private AndroidDriver<AndroidElement> driver;
        private readonly string query = "Prada Eyewear";

        [SetUp]
        public void Setup()
        {
            farfetchBusinessObject = new FarfetchBusinessObject(AndroidDriver.getDriver());
        }

        [Test(Description = "Making a search test")]
        [AllureOwner("Kirill")]
        [AllureSubSuite("Search test")]
        public void MakeASearchTest()
        {
            farfetchBusinessObject.SkipInitialPages().MakeSearch(query);
            Assert.AreEqual(query, farfetchBusinessObject.GetProductName());
        }

        [Test(Description = "Adding an item to wishlist test")]
        [AllureOwner("Kirill")]
        [AllureSubSuite("Wishlist test")]
        public void CheckAddToWishlist()
        {
            farfetchBusinessObject.SkipInitialPages().MakeSearch(query).AddItemToWishList();
            Assert.AreEqual("WISHLIST (1)", farfetchBusinessObject.GetWishlistHeader());
        }

        [Test(Description = "Adding an item to shopping bag test")]
        [AllureOwner("Kirill")]
        [AllureSubSuite("Shopping bag test")]
        public void CheckAddToBag()
        {
            farfetchBusinessObject.SkipInitialPages().MakeSearch(query).ClickOnProduct().AddToCart().ClickGoToBag();
            Assert.AreEqual("SHOPPING BAG (1)", farfetchBusinessObject.GetBagCounter());
        }

        [TearDown]
        public void TearDown()
        {
            AndroidDriver.quitDriver();
        }
    }
}