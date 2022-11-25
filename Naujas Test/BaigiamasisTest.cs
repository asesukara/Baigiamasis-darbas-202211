using BaigiamasisDarbas.Page;
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
            FivePageMethodsPage.NavigateToPage();
            FivePageMethodsPage.ClosePopupButton();
            FivePageMethodsPage.InsertTextToInputField("tapetų klijai Metylan 180 g");
            FivePageMethodsPage.SearchButton();
            FivePageMethodsPage.AcceptCookies();
            FivePageMethodsPage.AddToCardFirstButton();
            FivePageMethodsPage.ContinueFirstButton();
            FivePageMethodsPage.AddToCardSecondButton();
            FivePageMethodsPage.ContinueSecondButton();
            FivePageMethodsPage.ContinueCardButton();
            FivePageMethodsPage.ClickkCardButton();
            FivePageMethodsPage.GoPayseraElement();
            FivePageMethodsPage.GoSebElement();
            FivePageMethodsPage.GoMasterCardElement();
            FivePageMethodsPage.GoVisaElement();
            FivePageMethodsPage.GoSwedbankElement();
            FivePageMethodsPage.GetAllFiveList();
            FivePageMethodsPage.CompareResultFivePayMethods();

        }

        [Order(2)]
        [Test]
        public static void TwoKaunasShopWorkSaturdayTest()
        {
            KaunasShopsWorkingInSaturdayPage.NavigateToPage();
            KaunasShopsWorkingInSaturdayPage.ClosePopupButton();
            KaunasShopsWorkingInSaturdayPage.AcceptCookies();
            KaunasShopsWorkingInSaturdayPage.GoToContacts();
            KaunasShopsWorkingInSaturdayPage.SelectKaunasButton();
            KaunasShopsWorkingInSaturdayPage.GetFirstShopElement();
            KaunasShopsWorkingInSaturdayPage.GetFirstShopWorkTime();
            KaunasShopsWorkingInSaturdayPage.GetSecondShopElement();
            KaunasShopsWorkingInSaturdayPage.GetSecondShopWorkTime();
            KaunasShopsWorkingInSaturdayPage.CompareResultRaudondvaris();
            KaunasShopsWorkingInSaturdayPage.CompareResultNarsieciu();
        }
        [Order(3)]
        [Test]
        public static void ThreeAccountElementsTest()
        {
            ThreeElInAccountPage.NavigateToPage();
            ThreeElInAccountPage.ClosePopupButton();
            ThreeElInAccountPage.AcceptCookies();
            ThreeElInAccountPage.ClickEShopButton();
            ThreeElInAccountPage.GetEShoplistResult();
            ThreeElInAccountPage.CompareElementsInAccount();
        }
        [Order(4)]
        [Test]
        public static void BlickTenSearchTest()
        {
            BlickTenSearchPage.NavigateToPage();
            BlickTenSearchPage.ClosePopupButton();
            BlickTenSearchPage.AcceptCookies();
            BlickTenSearchPage.InsertTextToInputField("Blick 10");
            BlickTenSearchPage.SearchButton();
            BlickTenSearchPage.ResultKeyElement();
            BlickTenSearchPage.SearchVerifyResult();
        }
        [Order(5)]
        [Test]
        public static void TwoMethylanGlueCountTest()
        {
            TwoMethylanGlueCountPage.NavigateToPage();
            TwoMethylanGlueCountPage.CloseAllPopupButton();
            TwoMethylanGlueCountPage.InsertTextToInputField("tapetų klijai Metylan 180 g");
            TwoMethylanGlueCountPage.SearchButton();
            TwoMethylanGlueCountPage.AcceptCookies();
            TwoMethylanGlueCountPage.AddToCardFirstButton();
            TwoMethylanGlueCountPage.ContinueFirstButton();
            TwoMethylanGlueCountPage.AddToCardSecondButton();
            TwoMethylanGlueCountPage.ContinueSecondButton();
            TwoMethylanGlueCountPage.ContinueCardButton();
            TwoMethylanGlueCountPage.ClickCardButton();
            TwoMethylanGlueCountPage.MethylanWoodchip2Button();
            TwoMethylanGlueCountPage.MethylanWoodchipElement2("2");
            TwoMethylanGlueCountPage.MethylanVinylAndSpezial1Element("1");
            TwoMethylanGlueCountPage.CompareTwoCountResult();
            TwoMethylanGlueCountPage.GetIntTwoCountResult();
        }

    }

}




