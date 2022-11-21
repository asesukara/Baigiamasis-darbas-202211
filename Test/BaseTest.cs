using BaigiamasisDarbas.Page;
using BaigiamasisDarbas.Tools;
using ClassLibrary1.Page;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace BaigiamasisDarbas.Test
{
    public class BaseTest
    {
        protected static WebDriver chromeDriver;
        protected static FivePageMethodsPage page;
        protected static KaunasShopsWorkingInSaturdayPage page2;
        protected static TrysElPaskyrojePage page3;
        protected static BlickTenSearchPage page4;
        protected static TwoMethylanGlueCountPage page5;
        protected static BaseDriver page6;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            chromeDriver = new ChromeDriver();
            page = new FivePageMethodsPage(chromeDriver);
            page2 = new KaunasShopsWorkingInSaturdayPage(chromeDriver);
            page3 = new TrysElPaskyrojePage(chromeDriver);
            page4 = new BlickTenSearchPage(chromeDriver);
            page5 = new TwoMethylanGlueCountPage(chromeDriver);
            page6 = new BaseDriver(chromeDriver);
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(chromeDriver);
            }
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            chromeDriver.Quit();
        }

    }
}
