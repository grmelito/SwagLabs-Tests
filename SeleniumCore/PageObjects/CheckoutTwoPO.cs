using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCore.PageObjects
{
    public class CheckoutTwoPO
    {
        private IWebDriver _driver;
        private By finishButton;
        private By cancelButton;

        public CheckoutTwoPO(IWebDriver driver)
        {
            this._driver = driver;
            finishButton = By.ClassName("cart_button");
            cancelButton = By.ClassName("cart_cancel_link");
        }
        public void finishPurchase()
        {
            _driver.FindElement(finishButton).Click();
        }

        public void cancelPurchase()
        {
            _driver.FindElement(cancelButton).Click();
        }
    }
}
