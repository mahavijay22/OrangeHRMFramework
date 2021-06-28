using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maveric.OrangeHRMApplication.OrangeHRMPages
{
    class DashboardPage
    {

        private static By EmployeeDistributionHeaderLocator = By.XPath("//legend[contains(text(),'Distribution')]");
        
        public static string GetEmployeeDistributionByUnitHeader(IWebDriver driver)
        {
            return driver.FindElement(EmployeeDistributionHeaderLocator).Text;
        }

    }
}
