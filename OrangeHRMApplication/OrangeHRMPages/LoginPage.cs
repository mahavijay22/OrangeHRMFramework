using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace  Maveric.OrangeHRMApplication.OrangeHRMPages
{
    class LoginPage
    {
        private static By usernameLocater = By.Id("txtUsername");
        private static By PasswordLocater = By.Id("txtPassword");
        private static By SubmitButtonLocator = By.Name("Submit");
        private static By InvalidCredentialsErrorLocator = By.Id("spanMessage");
        private static By UsernameEmptyErrorLocator = By.Id("spanMessage");
        private static By PasswordEmptyErrorLocator= By.Id("spanMessage");
        public static void EnterUsername(IWebDriver driver, String UName)
        {
         IWebElement UserName= driver.FindElement(usernameLocater);
            UserName.SendKeys(UName);
            
        }

        public static void EnterPassword(IWebDriver driver, String Pswd)
        {
            IWebElement Password = driver.FindElement(PasswordLocater);
            Password.SendKeys(Pswd);
        }

        public static void ClickSubmit(IWebDriver driver)
        {
            IWebElement submitbutton = driver.FindElement(SubmitButtonLocator);
            submitbutton.Click();
        }

        public static string GetInvalidCredentialsErrorMsg(IWebDriver driver)
        {
            return driver.FindElement(InvalidCredentialsErrorLocator).Text;
        }

        public static string GetUsernameEmptyErrorMessage(IWebDriver driver)
        {
            return driver.FindElement(UsernameEmptyErrorLocator).Text;
        }

        public static string GetPasswordErrorMessage(IWebDriver driver)
        {
            return driver.FindElement(PasswordEmptyErrorLocator).Text;
        }
    }
    }

