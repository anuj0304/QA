using MyNunitAutomationFramework.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyNunitAutomationFramework
{
    public class BaseTest
    {
        protected static IWebDriver driver; 

        [SetUpFixture]
        public class TestFixtureSetup
        {
            [OneTimeSetUp]
            public void Setup()
            {
                if (driver == null)
                {
                    string directoryPath = @"C:\Selenium_Test\MyNunitAutomationFramework\Reports";
                    string dateTimeString = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                    string reportFileName = $"ExtentReport_{dateTimeString}.html";
                    string reportFilePath = Path.Combine(directoryPath, reportFileName);

                    // Create the directory if it doesn't exist
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    ExtentReportUtility.StartReport(reportFilePath);

                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                }
            }

            [OneTimeTearDown]
            public void Teardown()
            {
                ExtentReportUtility.EndReport();

                if (driver != null)
                {
                    driver.Quit();

                }
            }
        }
    }
}
