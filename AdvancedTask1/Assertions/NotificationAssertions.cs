using AdvancedTask1.Pages.Notification;
using AdvancedTask1.Pages.Notification.Component;
using AdvancedTask1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Assertions
{
    internal class NotificationAssertions
    {
        public readonly IWebDriver driver;

        public readonly NotificationPage notificationPageObj;
        public readonly NotificationComponent notificationComponentObj;

        public NotificationAssertions(IWebDriver driver)
        {
            this.driver = driver;
            notificationPageObj = new NotificationPage(driver);
            notificationComponentObj = new NotificationComponent(driver);
        }

        public void AssertMoreNotificationShowm()
        {
            Wait.WaitIsVisible(driver, "XPath", "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[11]/div[1]/center/a", 10);
            Assert.That(notificationComponentObj.NotificationRecords > 5, "More Notifications weren't shown");
        }

        public void AssertLessNotificationsShown()
        {
            Wait.WaitIsVisible(driver, "XPath", "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a", 10);
            Assert.That(notificationComponentObj.NotificationRecords <= 5, "More Notifications shown");
        }

    }
}
