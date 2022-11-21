using OpenQA.Selenium;
using System;

namespace ClassLibrary1.Page
{
    public class BaseDriver
    {
        protected static IWebDriver Driver;
        private const string pageUrl = "https://www.mokivezi.lt";
        public BaseDriver(IWebDriver webdriver)
        {
            Driver = webdriver;

        }
        public void NavigateToPage()
        {
            if (Driver.Url != pageUrl)
            {
                Driver.Url = pageUrl;
            }
        }
        public void AcceptCookies()
        {
            Cookie myCookie = new Cookie("notice_agreement",
                "agreed",
                "mokivezi.lt",
                "/",
                DateTime.Now.AddMonths(6));
            Driver.Manage().Cookies.AddCookie(myCookie);
            Driver.Navigate().Refresh();
        }

    }
}
