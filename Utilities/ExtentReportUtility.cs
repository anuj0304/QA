using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNunitAutomationFramework.Utilities
{
    public static class ExtentReportUtility
    {

        private static ExtentReports extent;
        private static ExtentHtmlReporter htmlReporter;

        public static void StartReport(string reportPath)
        {
            htmlReporter = new ExtentHtmlReporter(reportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            
        }

        public static void EndReport()
        {
            extent.Flush();
        }

        public static void LogTestStep(Status status, string message)
        {
            extent.CreateTest(TestContext.CurrentContext.Test.Name).Log(status, message);
        }

       
    }
}
