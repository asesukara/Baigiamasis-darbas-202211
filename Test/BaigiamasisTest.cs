using BaigiamasisDarbas.Test;
using NUnit.Framework;

namespace ClassLibrary2.Test
{
    public class BaigiamasisDTest : BaseTest
    {

        [Order(1)]
        [Test]
        public static void FivePayMethodsTest()
        {
            page.NavigateToPage();
            page.CloseAllPopuppButton();
            page.InsertTextToInputField("tapetų klijai Metylan 180 g");
            page.SearchButton();
            page.AcceptCookies();
            page.AddToCardFirstButton();
            page.ContinueFirstButton();
            page.AddToCardSecondButton();
            page.ContinueSecondButton();
            page.ContinueCardButton();
            page.clickkCardButton();
            page.PayseraElement();
            page.SebElement();
            page.MasterCardElement();
            page.VisaElement();
            page.SwedbankElement();
            page.AllFiveList();
            page.ResultFivePayMethods();

        }

        [Order(2)]
        [Test]
        public static void TwoKaunasShopWorkSaturdayTest()
        {
            page2.NavigateToPage();
            page2.CloseAllPopuppButton();
            page2.AcceptCookies();
            page2.ContactsButton();
            page2.SelectKaunasButton();
            page2.FirstShopElement();
            page2.FirstShopWorkTime();
            page2.SecondShopElement();
            page2.SecondShopWorkTime();
            page2.ResultRaudondvaris();
            page2.ResultNarsieciu();
        }
        [Order(3)]
        [Test]
        public static void ThreeAccountElementsTest()
        {
            page3.NavigateToPage();
            page3.CloseAllPopuppButton();
            page3.AcceptCookies();
            page3.clickkEParduotuveButton();
            page3.EShoplistResult();
            page3.ArTrysElPaskyroje();
        }
        [Order(4)]
        [Test]
        public static void BlickTenSearchTest()
        {
            page4.NavigateToPage();
            page4.CloseAllPopuppButton();
            page4.AcceptCookies();
            page4.InsertTextToInputField("Blick 10");
            page4.SearchButton();
            page4.ResultKeyElement();
            page4.SearchVerifyResult();
        }
        [Order(5)]
        [Test]
        public static void TwoMethylanGlueCountTest()
        {
            page5.NavigateToPage();
            page5.CloseAllPopuppButton();
            page5.InsertTextToInputField("tapetų klijai Metylan 180 g");
            page5.SearchButton();
            page5.AcceptCookies();
            page5.AddToCardFirstButton();
            page5.ContinueFirstButton();
            page5.AddToCardSecondButton();
            page5.ContinueSecondButton();
            page5.ContinueCardButton();
            page5.ClickkCardButton();
            page5.MethylanWoodchip2Button();
            page5.MethylanWoodchipElement2("2");
            page5.MethylanVinylAndSpezial1Element("1");
            page5.TwoCountResult();
            page5.IntTwoCountResult();
        }

    }

}




