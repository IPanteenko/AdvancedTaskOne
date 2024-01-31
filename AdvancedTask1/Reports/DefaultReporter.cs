using AdvancedTask1.Utilities;
using AventStack.ExtentReports.Listener.Entity;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Reports
{
    internal class DefaultReporter
    {
        const string defaultReportsFolder = "Reports";
        const string defaultReportsFilename = "TestRunReport";

        public IObserver<ReportEntity> GetDefaultReporter(string reportName)
        {
            FileSystem.CreateDirectory(defaultReportsFolder);
            return new ExtentSparkReporter($"{FileSystem.GetRootDirectory()}\\{defaultReportsFolder}\\{reportName ?? defaultReportsFilename}.html");
        }
    }
}
