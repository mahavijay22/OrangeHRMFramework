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

        public static object[] InvalidCredentialData()
        {
            object[] temp1 = new object[4];
            temp1[0] = "John";
            temp1[1] = "John123";
            temp1[2] = "English (Indian)";
            temp1[3] = "Invalid username or password";

            object[] temp2 = new object[4];
            temp2[0] = "King";
            temp2[1] = "King123";
            temp2[2] = "Dutch";
            temp2[3] = "Invalid username or password";


            object[] main = new object[4];
            main[0] = temp1;
            main[1] = temp2;
            return main;
        }

    }
}
