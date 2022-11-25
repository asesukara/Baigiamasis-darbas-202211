using ClassLibrary1.Page;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BaigiamasisDarbas.Page
{
    public class TwoKaunasShopsWorkingInSaturdayPage : BaseDriver
    {
        private const string KaunasFirstShop = "Kaunas, Raudondvario pl. 205 ";
        private const string WorkTimeFirstShop = "08:00 - 17:00";
        private const string sum = KaunasFirstShop + WorkTimeFirstShop;
        private const string KaunasSecondShop = "Kaunas, Kauno r., Narsiečių k., Vytauto g. 183 ";
        private const string WorkTimeSecondShop = "08:00 - 18:00";
        private const string sum3 = KaunasSecondShop + WorkTimeSecondShop;
        private IWebElement closePopupButton => Driver.FindElement(By.Id("omnisend-form-637decc6f247da47b9abaf35-close-action"));
        private IWebElement contactsButton => Driver.FindElement(By.CssSelector("#footer > div.container.footer__grid > div:nth-child(1) > div.col-12.col-lg-9 > div > div:nth-child(3) > ul > li:nth-child(1) > a"));
        private IWebElement selectKaunasButton => Driver.FindElement(By.CssSelector("#citySelect > option:nth-child(5)"));
        private IWebElement firstShopElement => Driver.FindElement(By.CssSelector("body > div.main-content.container > div.row > div:nth-child(6) > div > div.d-flex.align-items-start.contact-shop__address-wrapper > div.contact-shop__address"));
        private IWebElement firstShopWorkTime => Driver.FindElement(By.CssSelector("body > div.main-content.container > div.row > div:nth-child(6) > div > div:nth-child(8) > div:nth-child(2)"));
        private IWebElement secondShopElement => Driver.FindElement(By.CssSelector("body > div.main-content.container > div.row > div:nth-child(5) > div > div.d-flex.align-items-start.contact-shop__address-wrapper > div.contact-shop__address"));
        private IWebElement secondShopWorkTime => Driver.FindElement(By.CssSelector("body > div.main-content.container > div.row > div:nth-child(5) > div > div:nth-child(8) > div:nth-child(2)"));
        public TwoKaunasShopsWorkingInSaturdayPage(IWebDriver driver) : base(driver) { }
        public void ClosePopupButton()
        {
            closePopupButton.Click();
        }
        public void GoToContacts()
        {
            contactsButton.Click();
        }
        public void SelectKaunasButton()
        {
            selectKaunasButton.Click();
        }
        public void GetFirstShopElement()
        {
            firstShopElement.Click();
        }
        public void GetFirstShopWorkTime()
        {
            firstShopWorkTime.Click();
        }
        public void GetSecondShopElement()
        {
            secondShopElement.Click();
        }
        public void GetSecondShopWorkTime()
        {
            secondShopWorkTime.Click();
        }
        public void CompareResultRaudondvaris()
        {
            string sum2 = firstShopElement.Text + " " + firstShopWorkTime.Text;
            Assert.AreEqual(sum, sum2, "different work time");
        }
        public void CompareResultNarsieciu()
        {
            string sum4 = secondShopElement.Text + " " + secondShopWorkTime.Text;
            Assert.AreEqual(sum3, sum4, "different work time");
        }
    }
}
