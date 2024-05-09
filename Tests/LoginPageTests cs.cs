using AventStack.ExtentReports;
using MyNunitAutomationFramework.Pages;
using MyNunitAutomationFramework.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNunitAutomationFramework.Tests
{
    public  class LoginPageTests_cs : BaseTest
    {

        [Test]
        public void Test_Login()
        {
            // Arrange
           string username = "standard_user";
           string password = "secret_sauce";
 

            // Act
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login(username, password);
            

            Thread.Sleep(1000);

            ExtentReportUtility.LogTestStep(Status.Pass, "Login test passed");


        }
    }
}
