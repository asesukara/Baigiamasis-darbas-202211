using ClassLibrary1.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace BaigiamasisDarbas.Page
{
    public class FivePageMethodsPage : BaseDriver
    {
        private IWebElement closePopupButton => Driver.FindElement(By.Id("omnisend-form-63285e2b018728915f150e04-close-action"));
        private IWebElement inputField => Driver.FindElement(By.Id("search"));
        private IWebElement searchButton => Driver.FindElement(By.CssSelector(".btn.btn-primary.header-search-form__submit-btn.medium-link"));
        private IWebElement addToCardFirstButton => Driver.FindElement(By.CssSelector("body > div.main-content.container > div > div.col-12.col-md-8.col-lg-9.loadable > div.row.row--small-gutter.mt-5 > div:nth-child(1) > div > div.position-relative > div > form > div.product-quantity > div.pl-xl-0.product-quantity__col-submit > button.btn.btn-block.btn-primary.product-quantity__submit.item-add-to-cart"));
        private IWebElement continueFirstButton => Driver.FindElement(By.CssSelector(".btn.btn-transparent"));
        private IWebElement addToCardSecondButton => Driver.FindElement(By.CssSelector("body > div.main-content.container > div > div.col-12.col-md-8.col-lg-9.loadable > div.row.row--small-gutter.mt-5 > div:nth-child(2) > div > div.position-relative > div > form > div.product-quantity > div.pl-xl-0.product-quantity__col-submit > button.btn.btn-block.btn-primary.product-quantity__submit.item-add-to-cart"));
        private IWebElement continueSecondButton => Driver.FindElement(By.CssSelector(".btn.btn-transparent"));
        private IWebElement continueCardButton => Driver.FindElement(By.CssSelector("body > header > div.header-category-container.mt-4 > div > div > nav > div.col-3.header-categories__side.header-categories__side--right > div > div.mr-2.dropdown-btn-wrapper > div > div.input-style-reset.basket-btn.d-flex.align-items-center.noselect > span.basket-btn__text.medium-link.mx-1.d-none.d-md-block"));
        private IWebElement clickCardButton => Driver.FindElement(By.CssSelector("body > header > div.header-category-container.mt-4 > div > div > nav > div.col-3.header-categories__side.header-categories__side--right > div > div.mr-2.dropdown-btn-wrapper > div > div.dropdown-menu.dropdown-menu-right.p-0.mini-cart__dropdown.show > div.mini-cart__btn-wrapper > a.btn.btn-primary.btn-block.mini-cart__btn"));
        private IWebElement payseraElement => Driver.FindElement(By.CssSelector("body > div.footer-bottom.mt-4 > div > div > div > div:nth-child(2) > div > img:nth-child(1)"));
        private IWebElement sebElement => Driver.FindElement(By.CssSelector("body > div.footer-bottom.mt-4 > div > div > div > div:nth-child(2) > div > img:nth-child(2)"));
        private IWebElement mastercardElement => Driver.FindElement(By.CssSelector("body > div.footer-bottom.mt-4 > div > div > div > div:nth-child(2) > div > img:nth-child(3)"));
        private IWebElement visaElement => Driver.FindElement(By.CssSelector("body > div.footer-bottom.mt-4 > div > div > div > div:nth-child(2) > div > img:nth-child(4)"));
        private IWebElement swedbankElement => Driver.FindElement(By.CssSelector("body > div.footer-bottom.mt-4 > div > div > div > div:nth-child(2) > div > img:nth-child(5)"));
        private IReadOnlyCollection<IWebElement> fivePayMethods => Driver.FindElements(By.CssSelector(".footer-bottom__list__item"));

        public FivePageMethodsPage(IWebDriver driver) : base(driver) { }
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
        public void AddToCardFirstButton()
        {
            addToCardFirstButton.Click();
        }
        public void ContinueFirstButton()
        {
            continueFirstButton.Click();
        }
        public void AddToCardSecondButton()
        {
            addToCardSecondButton.Click();
        }
        public void ContinueSecondButton()
        {
            continueSecondButton.Click();
        }
        public void ContinueCardButton()
        {
            continueCardButton.Click();
        }
        public void clickkCardButton()
        {
            clickCardButton.Click();
        }
        public void PayseraElement()
        {
            payseraElement.Click();
        }
        public void SebElement()
        {
            sebElement.Click();
        }
        public void MasterCardElement()
        {
            mastercardElement.Click();
        }
        public void VisaElement()
        {
            visaElement.Click();
        }
        public void SwedbankElement()
        {
            swedbankElement.Click();
        }
        public void AllFiveList()
        {
            fivePayMethods.Count();
        }
        public void ResultFivePayMethods()
        {
            Assert.IsTrue(5 == fivePayMethods.Count(), "Mokejimo budu kiekis neatitinka");
        }

    }
}
