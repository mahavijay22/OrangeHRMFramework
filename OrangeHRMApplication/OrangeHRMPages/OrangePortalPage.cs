using Maveric.OrangeHRMApplication.OrangeHRMBase;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maveric.OrangeHRMApplication.OrangeHRMPages
{
    class OrangePortalPage : WebDriverWrapper
    {

        private static By profileIconLocator = By.Id("welcome");
        private static By aboutLocator = By.LinkText("About");
        private static By companyDetailLocator = By.Id("companyInfo");
        public static void ClickOnMyInfoMenu()
        {

        }
        public static void ClickOnDashboardMenu()
        {

        }

        public static void ClickOnDirectoryMenu()
        {

        }
        public static void ClickOnProfileIcon(IWebDriver driver)
        {
            driver.FindElement(profileIconLocator).Click();
        }
        public static void ClickOnAbout(IWebDriver driver)
        {
            driver.FindElement(aboutLocator).Click();
        }

        public static String GetAboutSectionDetail(IWebDriver driver)
        {
            return driver.FindElement(companyDetailLocator).Text;
        }
    }
}
