using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maveric.OrangeHRMApplication.OrangeHRMBase
{
    class WebDriverWrapper
    {
     protected   IWebDriver driver;

        [SetUp]
        public void Orangesetup()
        {
            string browser = "chrome";
            if (browser.ToLower().Equals("chrome"))
            {
                driver = new ChromeDriver();
            }else if  (browser.ToLower().Equals("internetexplorer"))
            {
                driver = new InternetExplorerDriver();
            }
            
            else if (browser.ToLower().Equals("firefox"))
            {
                driver = new FirefoxDriver();
            } else
            {
                Console.WriteLine("Browser  not Launched");
            }
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
        }
        [TearDown]
        public void OrangeTeardown()
        {
            driver.Quit();
        }
    }
}
