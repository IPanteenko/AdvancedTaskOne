using AdvancedTask1.Utilities;
using AventStack.ExtentReports.Listener.Entity;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Reports
{
    internal class ScreenshotTaker
    {
        readonly IWebDriver driver;

        const string defaultScreenshotsFolder = "Screenshots";
        readonly string defaultScreenshotFilename = "Screenshot_";

        public ScreenshotTaker(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string TakeScreenshot()
        {
            var screenshotPath = $"{FileSystem.GetRootDirectory()}\\{defaultScreenshotsFolder}\\{defaultScreenshotFilename}{DateTime.Now.ToString("h_mm_ss")}.png";

            ITakesScreenshot takeScreenshotDriver = (ITakesScreenshot)driver;
            Screenshot screenshot = takeScreenshotDriver.GetScreenshot();

            FileSystem.CreateDirectory(defaultScreenshotsFolder);
            screenshot.SaveAsFile(new Uri(screenshotPath).LocalPath);
            return screenshotPath;
        }
    }
}
