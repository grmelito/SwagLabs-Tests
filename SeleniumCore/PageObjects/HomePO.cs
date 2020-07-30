using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCore.PageObjects
{
    public class HomePO
    {
        private IWebDriver _driver;
        private By userNameField;
        private By passwordField;
        private By loginButton;
        private By err_message;

        public HomePO(IWebDriver driver)
        {
            this._driver = driver;
            userNameField = By.Id("user-name");
            passwordField = By.Id("password");
            loginButton = By.Id("login-button");
            err_message = By.XPath("/html/body/div[2]/div[1]/div/div/form/h3");
        }
        public void Visit()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }
        public void SubmitForm()
        {
            _driver.FindElement(loginButton).Click();
        }
        public void FillForm(string username, string password)
        {
            _driver.FindElement(userNameField).SendKeys(username);
            _driver.FindElement(passwordField).SendKeys(password);
           
        }
        public void FillFormWrong(string username, string password)
        {
            _driver.FindElement(userNameField).SendKeys(username);
            _driver.FindElement(passwordField).SendKeys(password);

        }
    }
}
