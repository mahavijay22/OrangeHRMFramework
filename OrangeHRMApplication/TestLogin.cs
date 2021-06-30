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
        

        [Test]
        
        public void ValidCredentialTest(String Username,String Password,String EmpDistributionText)
        {

            LoginPage.EnterUsername(driver, Username);
            LoginPage.EnterPassword(driver, Password);
            LoginPage.ClickSubmit(driver);
            String EmpDistribution = DashboardMenuPage.GetEmployeeDistributionByUnitHeader(driver);
            Assert.AreEqual(EmpDistributionText, EmpDistribution);
        }
        public static object[] InvalidCredentialData()
        {
            object[] temp1 = new object[3];
            temp1[0] = "admin";
            temp1[1] = "admin23";
            temp1[2] = "Invalid credentials";

          /*  object[] temp2 = new object[3];
            temp2[0] = "admin1";
            temp2[1] = "admin1223";
            temp2[2] = "Invalid Credentials";*/

            object[] main = new object[1];
            main[0] = temp1;
           // main[1] = temp2;
            return main;
        }



        [Test]
       [TestCaseSource("InvalidCredentialData")]
        public void InValidCredentialTest(String Username, String Password, String Error)
        {

            LoginPage.EnterUsername(driver, Username);
            LoginPage.EnterPassword(driver, Password);
            LoginPage.ClickSubmit(driver);

            String actualerror = LoginPage.GetInvalidCredentialsErrorMsg(driver);
            Assert.AreEqual(Error, actualerror);
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
