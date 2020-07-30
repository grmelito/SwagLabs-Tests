using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumCore.PageObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace SeleniumCore
{
    [TestClass]
    public class InventoryFeatures
    {
        IWebDriver _driver;
        [TestMethod]
        public void ShouldBeAbleToCompletePurchase()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _driver = new FirefoxDriver(outPutDirectory);
            var InventoryPO = new InventoryPO(_driver);
            var CartPO = new CartPO(_driver);
            var CheckoutOnePO = new CheckoutOnePO(_driver);
            var CheckoutTwoPO = new CheckoutTwoPO(_driver);

            InventoryPO.Visit();
            InventoryPO.addAllItemsToCart();
            CartPO.confirmCart();
            CheckoutOnePO.fillInformationForm("Andrei", "Gonçalves", "1109657");
            CheckoutOnePO.submitForm();
            CheckoutTwoPO.finishPurchase();

            Assert.IsTrue(_driver.Url.Contains("checkout-complete.html"));
        }
    }
}
