using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Maveric.OrangeHRMApplication.OrangeHRMPages;
using OpenQA.Selenium;
using Maveric.OrangeHRMApplication.OrangeHRMBase;

namespace Maveric.OrangeHRMApplication
{
    class AboutTest : WebDriverWrapper
    { 
    [Test]
  public void  AboutSectionTest()  {

            LoginPage.EnterUsername(driver, "admin");
            LoginPage.EnterPassword(driver, "admin123");
            LoginPage.ClickSubmit(driver);

            OrangePortalPage.ClickOnProfileIcon(driver);
            OrangePortalPage.ClickOnAbout(driver);
            String CompanyName = OrangePortalPage.GetAboutSectionDetail(driver);
            Console.WriteLine(CompanyName);

            Assert.True(CompanyName.Contains("Company Name: OrangeHRM"));
            Assert.True(CompanyName.Contains("Version: Orangehrm OS 4.8"));
            Assert.True(CompanyName.Contains("Active Employees: 42"));
            Assert.True(CompanyName.Contains("Employees Terminated: 0"));
        }
      
        }
    }

