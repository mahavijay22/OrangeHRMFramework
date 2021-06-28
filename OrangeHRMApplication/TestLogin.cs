using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Maveric.OrangeHRMApplication.OrangeHRMPages;
using System;
using Maveric.OrangeHRMApplication.OrangeHRMBase;

namespace Maveric.OrangeHRMApplication
{
    class TestLogin : WebDriverWrapper
    {
        IWebDriver driver ;
         [SetUp]
        public void Orangesetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
        }
        [TearDown]
        public void OrangeTeardown()
        {
            driver.Quit();
        }

        [Test]
        public void ValidCredentialTest()
        {

            LoginPage.EnterUsername(driver, "admin");
            LoginPage.EnterPassword(driver, "admin123");
            LoginPage.ClickSubmit(driver);
            String EmpDistribution = DashboardPage.GetEmployeeDistributionByUnitHeader(driver);
            Assert.AreEqual("Employee Distribution by Subunit", EmpDistribution);
        }

        [Test]
        public void InValidCredentialTest()
        {

            LoginPage.EnterUsername(driver, "admin");
            LoginPage.EnterPassword(driver, "admin23");
            LoginPage.ClickSubmit(driver);

            String actualerror = LoginPage.GetInvalidCredentialsErrorMsg(driver);
            Assert.AreEqual("Invalid credentials", actualerror);
            Console.WriteLine("actualValue" + actualerror);
        }
        [Test]
        public void EmptyUsername() {

            LoginPage.ClickSubmit(driver);
            String actualUsernameEmpty = LoginPage.GetUsernameEmptyErrorMessage(driver);
            Assert.AreEqual("Username cannot be empty", actualUsernameEmpty);
        }
        [Test]
        public void EmptyPassword()
        {
            LoginPage.EnterUsername(driver, "admin");
            LoginPage.ClickSubmit(driver);
            String actualPasswordEmpty = LoginPage.GetPasswordErrorMessage(driver);
            Assert.AreEqual("Password cannot be empty", actualPasswordEmpty);
        }
    }
}
