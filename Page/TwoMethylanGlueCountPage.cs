using ClassLibrary1.Page;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BaigiamasisDarbas.Page
{
    public class TwoMethylanGlueCountPage : BaseDriver
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
        private IWebElement methylanWoodchip2Button => Driver.FindElement(By.CssSelector("body > div.pt-2.pb-5 > div > div > div.col-12.col-lg-8.mb-4 > div.cart-items.js-cart-items > div > form > div:nth-child(3) > div.col-4.col-lg-2.d-flex.justify-content-center.align-items-center > div > div > button.btn.product-quantity__increase"));
        private IWebElement methylanWoodchipElement2 => Driver.FindElement(By.Id("220169"));
        private IWebElement methylanVinylAndSpezial1Element => Driver.FindElement(By.Id("220166"));

        public TwoMethylanGlueCountPage(IWebDriver driver) : base(driver) { }
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
        public void ClickkCardButton()
        {
            clickCardButton.Click();
        }
        public void MethylanWoodchip2Button()
        {
            methylanWoodchip2Button.Click();
        }
        public void MethylanWoodchipElement2(string KiekisDu)
        {
            methylanWoodchipElement2.Click();
        }
        public void MethylanVinylAndSpezial1Element(string KiekisVienas)
        {
            methylanVinylAndSpezial1Element.Click();
        }
        public void TwoCountResult()
        {
            Assert.AreNotSame(methylanWoodchipElement2, methylanVinylAndSpezial1Element, "are equal");
        }
        public void IntTwoCountResult()
        {
            string KiekisDu = "2";
            string KiekisVienas = "1";
            int x1, x2;
            bool woodchipElementCount = int.TryParse(KiekisDu, out x1);

            bool methylanVinylCount = int.TryParse(KiekisVienas, out x2);

            Assert.IsTrue(x1 > x2, $"No,{woodchipElementCount} is less than {methylanVinylCount} ");
        }

    }
}
