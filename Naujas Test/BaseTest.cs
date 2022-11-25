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

        protected static IWebDriver chromeDriver;
        protected static FivePageMethodsPage FivePageMethodsPage;
        protected static TwoKaunasShopsWorkingInSaturdayPage KaunasShopsWorkingInSaturdayPage;
        protected static ThreeElInAccountPage ThreeElInAccountPage;
        protected static BlickTenSearchPage BlickTenSearchPage;
        protected static TwoMethylanGlueCountPage TwoMethylanGlueCountPage;
        protected static BaseDriver BaseDriver;
        protected static IWebDriver Driver;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            chromeDriver = new ChromeDriver();
            FivePageMethodsPage = new FivePageMethodsPage(chromeDriver);
            KaunasShopsWorkingInSaturdayPage = new TwoKaunasShopsWorkingInSaturdayPage(chromeDriver);
            ThreeElInAccountPage = new ThreeElInAccountPage(chromeDriver);
            BlickTenSearchPage = new BlickTenSearchPage(chromeDriver);
            TwoMethylanGlueCountPage = new TwoMethylanGlueCountPage(chromeDriver);
            BaseDriver = new BaseDriver(chromeDriver);
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
