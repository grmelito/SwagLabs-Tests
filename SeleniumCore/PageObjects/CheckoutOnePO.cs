using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCore.PageObjects
{
    public class CheckoutOnePO
    {
        private IWebDriver _driver;
        private By firstNameInput;
        private By lastNameInput;
        private By zipCodeInput;
        private By continueButton;

        public CheckoutOnePO(IWebDriver driver)
        {
            this._driver = driver;
            firstNameInput = By.Id("first-name");
            lastNameInput = By.Id("last-name");
            zipCodeInput = By.Id("postal-code");
            continueButton = By.ClassName("cart_button");
        }

        public void fillInformationForm(string name, string lastname, string zipcode)
        {
            _driver.FindElement(firstNameInput).SendKeys(name);
            _driver.FindElement(lastNameInput).SendKeys(lastname);
            _driver.FindElement(zipCodeInput).SendKeys(zipcode);
        }

        public void submitForm()
        {
            _driver.FindElement(continueButton).Click();
        }
    }
}
