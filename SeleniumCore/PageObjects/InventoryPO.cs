﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCore.PageObjects
{
    public class InventoryPO
    {
        private IWebDriver _driver;
        private By addCartButton;
        private By checkCartButton;
        private By removeCartButton;
        private By dropdownFilter;
        private By optionDropdown;
        private By productPrice;

        public InventoryPO(IWebDriver driver)
        {
            this._driver = driver;
            addCartButton = By.ClassName("btn_inventory");
            removeCartButton = By.ClassName("btn_secondary btn_inventory");
            checkCartButton = By.XPath("//*[name()='path' and contains(@fill,'currentCol')]");
            dropdownFilter = By.ClassName("product_sort_container");
            productPrice = By.ClassName("inventory_item_price");
            optionDropdown = By.XPath("/html/body/div/div[2]/div[2]/div/div[1]/div[3]/select/option[4]");
        }
        public void Visit()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/inventory.html");
        }
        public void addAllItemsToCart()
        {
            _driver.FindElements(addCartButton)[0].Click();
            _driver.FindElements(addCartButton)[1].Click();
            _driver.FindElements(addCartButton)[2].Click();
            _driver.FindElements(addCartButton)[3].Click();
            _driver.FindElements(addCartButton)[4].Click();
            _driver.FindElement(checkCartButton).Click();
        }
        public void filterByNameAtoZ()
        {
            var dropDownFilter = new SelectElement(_driver.FindElement(dropdownFilter));
            dropDownFilter.SelectByValue("az");
        }
        public void filterByNameZtoA()
        {
            _driver.FindElement(dropdownFilter).SendKeys("Name (Z to A)");
        }

        public void filterByLowPrice()
        {
            _driver.FindElement(dropdownFilter).SendKeys("Price (low to high)");
        }

        public void filterByHighPrice()
        {
            var dropDownFilter = new SelectElement(_driver.FindElement(dropdownFilter));
            dropDownFilter.SelectByValue("hilo");
            //IAction acaoDropDown = new Actions(_driver)
            //    .MoveToElement(dropwdownFilter)
            //    .Click()
            //    .MoveToElement(optionDropDown)
            //    .Click()
            //    .Build();

            //acaoDropDown.Perform();
            //_driver.FindElement(dropdownFilter).SendKeys("Price (high to low)");
            
        }


    }
}
