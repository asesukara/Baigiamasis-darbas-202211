﻿using ClassLibrary1.Page;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BaigiamasisDarbas.Page
{
    public class BlickTenSearchPage : BaseDriver
    {
        private IWebElement closePopupButton => Driver.FindElement(By.Id("omnisend-form-63285e2b018728915f150e04-close-action"));
        private IWebElement inputField => Driver.FindElement(By.Id("search"));
        private IWebElement searchButton => Driver.FindElement(By.CssSelector(".btn.btn-primary.header-search-form__submit-btn.medium-link"));
        private IWebElement resultKeyElement => Driver.FindElement(By.CssSelector("body > div.main-content.container > div > div:nth-child(1) > h1"));
        public BlickTenSearchPage(IWebDriver driver) : base(driver) { }
        public void CloseAllPopuppButton()
        {
            closePopupButton.Click();
        }
        public void InsertTextToInputField(string text)
        {
            inputField.SendKeys(text);
        }
        public void SearchButton()
        {
            searchButton.Click();
        }
        public void ResultKeyElement()
        {
            resultKeyElement.Click();
        }
        public void SearchVerifyResult()
        {
            string expectedResult = "Rezultatų raktažodžiui: \"Blick 10\" nerasta";
            Assert.AreEqual(expectedResult, resultKeyElement.Text, "Rezultatu nerasta");
        }
    }
}
