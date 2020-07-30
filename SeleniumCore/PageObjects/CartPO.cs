using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCore.PageObjects
{
    public class CartPO
    {
        private IWebDriver _driver;
        private By checkoutButton;
        private By continueShopButton;

        public CartPO(IWebDriver driver)
        {
            this._driver = driver;
            checkoutButton = By.ClassName("checkout_button");
            continueShopButton = By.ClassName("btn_secondary");
        }
        public void confirmCart()
        {
            _driver.FindElement(checkoutButton).Click();
            
        }
        public void continueShopping()
        {
            _driver.FindElement(continueShopButton).Click();
        }
    }
    
}
