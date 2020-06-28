using MarsQA_1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MarsQA_1
{
    public class ExtentManager
    {
        public static ExtentHtmlReporter htmlReporter;
        private static ExtentReports extent;

        private ExtentManager()
        {

        }

        public static object Theme { get; private set; }

        public static ExtentReports GetInstance()
        {
            if (extent == null)
            {


                //string startupPath = System.IO.Directory.GetCurrentDirectory();
                //string startupPathSubString = startupPath.Substring(0, 49);
               // string fullProjectPath = new Uri(startupPathSubString).LocalPath;
                string reportpath = @"C:\repo\onboarding.specflow\MarsQA-1\TestReport";

                htmlReporter = new ExtentHtmlReporter(reportpath);


                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("Host Name", "ABC");
                extent.AddSystemInfo("Environment", "Test QA");
                extent.AddSystemInfo("Username", "XYZ");
              htmlReporter.LoadConfig("urpath\\extent-config.xml"); //Get the config.xml file 
            }
            return extent;
        }
    }
}
