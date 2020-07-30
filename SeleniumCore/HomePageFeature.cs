using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumCore.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumCore
{
    [TestClass]
    public class HomepageFeature
    {
        
        IWebDriver _driver;
        [TestMethod]
        public void ShouldBeAbleToLogin()
        {
             var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _driver = new FirefoxDriver(outPutDirectory);
            var HomePO = new HomePO(_driver);
            HomePO.Visit();
            HomePO.FillForm("standard_user", "secret_sauce");
            HomePO.SubmitForm();

            Assert.IsTrue(_driver.Url.Contains("inventory.html"));
        }

        [TestMethod]
        public void ShouldNotBeAbleToLogin()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _driver = new FirefoxDriver(outPutDirectory);
            var HomePO = new HomePO(_driver);
            HomePO.Visit();
            HomePO.FillForm("WrongUser", "Admin1234");
            HomePO.SubmitForm();

           IWebElement err_message = _driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div/div/form/h3"));
            Assert.IsTrue(err_message.Displayed);
        }

        [TestCleanup]
        public void TearDown()
        {
            _driver.Quit();
        }

    }
}
