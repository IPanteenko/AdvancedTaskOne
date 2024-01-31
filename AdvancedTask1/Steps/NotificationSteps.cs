using AdvancedTask1.Pages.Notification;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Steps
{
    internal class NotificationSteps
    {
        private readonly NotificationPage notificationPageObj;

        public NotificationSteps(IWebDriver driver)
        {
            notificationPageObj = new NotificationPage(driver);
        }
        public void OpenNotifications()
        {
            notificationPageObj.OpenNotifications(); 
        }

        public void LoadMoreNotifications()
        {
            notificationPageObj.ClickLoadMoreButton();
        }

        public void ShowLessNotifications()
        {
            notificationPageObj.ClickShowLessButton();
        }
    }
}
