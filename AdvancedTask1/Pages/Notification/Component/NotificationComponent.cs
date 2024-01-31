using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Pages.Notification.Component
{
    internal class NotificationComponent
    {
        private readonly IWebDriver driver;
       
        public NotificationComponent(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement LoadMoreButton => driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a"));
        public IWebElement ShowlessButton => driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[11]/div[1]/center/a"));
        public IWebElement SelectAllButton => driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[1]"));
        public IWebElement UnselectAllButton => driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[2]"));
        public IWebElement DeleteSelectedButton => driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[3]"));
        public IWebElement MarkSelectionAsReadButton => driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[4]"));
        public int NotificationRecords => driver.FindElements(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div/div[@class=\"ui grid\"]")).Count();
    }
}
