using ClassLibrary1.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace BaigiamasisDarbas.Page
{
    public class ThreeElInAccountPage : BaseDriver
    {
        private IWebElement closePopupButton => Driver.FindElement(By.Id("omnisend-form-637decc6f247da47b9abaf35-close-action"));
        private IWebElement clickEShopButton => Driver.FindElement(By.CssSelector(".header-categories__link.header-categories__link--account.link-unstyled.d-inline-block"));
        private IReadOnlyCollection<IWebElement> elementsCollection => Driver.FindElements(By.CssSelector(".btn-block.mini-cart__btn"));

        public ThreeElInAccountPage(IWebDriver driver) : base(driver) { }
        public void ClosePopupButton()
        {
            closePopupButton.Click();
        }
        public void ClickEShopButton()
        {
            clickEShopButton.Click();
        }
        public void GetEShoplistResult()
        {
            elementsCollection.Count();
        }
        public void CompareElementsInAccount()
        {
            Assert.AreNotEqual(2 == elementsCollection.Count(), "It is not true");
        }

    }
}
