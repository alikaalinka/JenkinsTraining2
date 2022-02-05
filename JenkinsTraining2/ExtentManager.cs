using System;
using System.Collections.Generic;
using System.Text;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Configuration;

namespace JenkinsTraining
{
    public class ExtentManager
    {
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;

        public static ExtentReports GetInstance() 
        {
            if (extent == null)
            {
                var reportPath = @"C:\Users\Стас\source\repos\JenkinsTraining\JenkinsTraining\Report.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);

                var extentConfigPath = @"C:\Users\Стас\source\repos\JenkinsTraining\JenkinsTraining\extent-config.xml";
                htmlReporter.LoadConfig(extentConfigPath);

            }

            return extent;
        }
    }
}
