using ClosedXML.Excel;
using Maveric.OrangeHRMApplication.OrangeHRMBase;
using Maveric.OrangeHRMApplication.OrangeHRMPages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRMApplication
{
    class DemoTest1 : WebDriverWrapper
    {
        [Test]
        public void passTestData()
        {

            IXLWorkbook book = new XLWorkbook("C:\\Users\\User\\Documents\\maveric\\Automation\\TestData.xlsx");
            IXLWorksheet sheet = book.Worksheet("InvalidCredentials");
            IXLRange range = sheet.RangeUsed();
            Console.WriteLine(range.RowCount());
            Console.WriteLine(range.ColumnCount());

            String cellvalue = Convert.ToString(range.Cell(1, 2).Value);
            Console.WriteLine(cellvalue);

            book.Dispose();
        }
        public static object[] InvalidCredentialData1()
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

        //   [Test]
        [TestCaseSource("InvalidCredentialData1")]
        public void InValidCredentialTest1(String Username, String Password, String Error)
        {

            LoginPage.EnterUsername(driver, Username);
            LoginPage.EnterPassword(driver, Password);
            LoginPage.ClickSubmit(driver);

            String actualerror = LoginPage.GetInvalidCredentialsErrorMsg(driver);
            Assert.AreEqual(Error, actualerror);
            Console.WriteLine("actualValue" + actualerror);
        }
    }
}
