using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace AdvancedTask1.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        private const string portalAddress = "http://localhost:5000/";

        public void OpenPortal()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(portalAddress);
            driver.Manage().Window.Maximize();
        }
    }
}
