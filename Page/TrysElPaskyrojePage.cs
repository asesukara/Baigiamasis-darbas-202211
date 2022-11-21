using ClassLibrary1.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace BaigiamasisDarbas.Page
{
    public class TrysElPaskyrojePage : BaseDriver
    {
        private IWebElement closePopupButton => Driver.FindElement(By.Id("omnisend-form-63285e2b018728915f150e04-close-action"));
        private IWebElement clickEParduotuveButton => Driver.FindElement(By.CssSelector(".header-categories__link.header-categories__link--account.link-unstyled.d-inline-block"));
        private IReadOnlyCollection<IWebElement> elementsCollection => Driver.FindElements(By.CssSelector(".btn-block.mini-cart__btn"));

        public TrysElPaskyrojePage(IWebDriver driver) : base(driver) { }
        public void CloseAllPopuppButton()
        {
            closePopupButton.Click();
        }
        public void clickkEParduotuveButton()
        {
            clickEParduotuveButton.Click();
        }
        public void EShoplistResult()
        {
            elementsCollection.Count();
        }
        public void ArTrysElPaskyroje()
        {
            Assert.AreNotEqual(2 == elementsCollection.Count(), "It is not true");
        }

    }
}
