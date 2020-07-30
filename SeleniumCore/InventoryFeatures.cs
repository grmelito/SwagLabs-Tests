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
        public void ShouldBeAbleToAddItems()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _driver = new FirefoxDriver(outPutDirectory);
            var InventoryPO = new InventoryPO(_driver);
            InventoryPO.Visit();
            InventoryPO.addAllItemsToCart();

            Assert.IsTrue(_driver.Url.Contains("cart.html"));
        }
    }
}
