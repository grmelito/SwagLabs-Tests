using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCore.PageObjects
{
    public class InventoryPO
    {
        private IWebDriver _driver;
        private By addCartButton;
        private By checkCartButton;

        public InventoryPO(IWebDriver driver)
        {
            this._driver = driver;
            addCartButton = By.ClassName("btn_inventory");
            checkCartButton = By.XPath("//*[name()='path' and contains(@fill,'currentCol')]");
        }
        public void Visit()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/inventory.html");
        }
        public void addAllItemsToCart()
        {
            _driver.FindElement(addCartButton).Click();
            _driver.FindElement(checkCartButton).Click();
        }


    }
}
