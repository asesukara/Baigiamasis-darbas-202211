using ClassLibrary1.Page;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BaigiamasisDarbas.Page
{
    public class KaunasShopsWorkingInSaturdayPage : BaseDriver
    {
        private IWebElement closePopupButton => Driver.FindElement(By.Id("omnisend-form-63285e2b018728915f150e04-close-action")); /*XPath netinka*///*[@label='Close']"*/
        private IWebElement contactsButton => Driver.FindElement(By.CssSelector("#footer > div.container.footer__grid > div:nth-child(1) > div.col-12.col-lg-9 > div > div:nth-child(3) > ul > li:nth-child(1) > a"));
        private IWebElement selectKaunasButton => Driver.FindElement(By.CssSelector("#citySelect > option:nth-child(5)"));
        private IWebElement firstShopElement => Driver.FindElement(By.CssSelector("body > div.main-content.container > div.row > div:nth-child(6) > div > div.d-flex.align-items-start.contact-shop__address-wrapper > div.contact-shop__address"));
        private IWebElement firstShopWorkTime => Driver.FindElement(By.CssSelector("body > div.main-content.container > div.row > div:nth-child(6) > div > div:nth-child(8) > div:nth-child(2)"));
        private IWebElement secondShopElement => Driver.FindElement(By.CssSelector("body > div.main-content.container > div.row > div:nth-child(5) > div > div.d-flex.align-items-start.contact-shop__address-wrapper > div.contact-shop__address"));
        private IWebElement secondShopWorkTime => Driver.FindElement(By.CssSelector("body > div.main-content.container > div.row > div:nth-child(5) > div > div:nth-child(8) > div:nth-child(2)"));
        public KaunasShopsWorkingInSaturdayPage(IWebDriver driver) : base(driver) { }
        public void CloseAllPopuppButton()
        {
            closePopupButton.Click();
        }
        public void ContactsButton()
        {
            contactsButton.Click();
        }
        public void SelectKaunasButton()
        {
            selectKaunasButton.Click();
        }
        public void FirstShopElement()
        {
            firstShopElement.Click();
        }
        public void FirstShopWorkTime()
        {
            firstShopWorkTime.Click();
        }
        public void SecondShopElement()
        {
            secondShopElement.Click();
        }
        public void SecondShopWorkTime()
        {
            secondShopWorkTime.Click();
        }
        public void ResultRaudondvaris()
        {
            string KaunoParduotuvePirma = "Kaunas, Raudondvario pl. 205 ";
            string DarboLaikasPirma = "08:00 - 17:00";
            string sum = KaunoParduotuvePirma + DarboLaikasPirma;
            string sum2 = firstShopElement.Text + " " + firstShopWorkTime.Text;
            Assert.AreEqual(sum, sum2, "rasta ne Kauno parduotuve");
        }
        public void ResultNarsieciu()
        {
            string KaunoParduotuveAntra = "Kaunas, Kauno r., Narsiečių k., Vytauto g. 183 ";
            string DarboLaikasAntra = "08:00 - 18:00";
            string sum3 = KaunoParduotuveAntra + DarboLaikasAntra;
            string sum4 = secondShopElement.Text + " " + secondShopWorkTime.Text;
            Assert.AreEqual(sum3, sum4, "Raso, kad nedirba sestadieni");
        }
    }
}
