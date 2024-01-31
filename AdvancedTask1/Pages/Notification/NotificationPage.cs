using AdvancedTask1.Pages.Components;
using AdvancedTask1.Pages.Notification.Component;
using AdvancedTask1.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Pages.Notification
{
    internal class NotificationPage
    {
        IWebDriver driver;
        private readonly NotificationComponent notificationComponentObj;
        private readonly NavigationMenuComponent navigationMenuComponentObj;

        public NotificationPage(IWebDriver driver)
        { 
            this.driver = driver;
            notificationComponentObj = new NotificationComponent(driver);
            navigationMenuComponentObj = new NavigationMenuComponent(driver);  
        }


        public void OpenNotifications()
        {
            Wait.WaitIsVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span", 5);
            navigationMenuComponentObj.DashBoardButton.Click();
        }

        
        public void ClickLoadMoreButton()
        {
            Wait.WaitToBEClickable(driver, "XPath", "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a", 10);
            notificationComponentObj.LoadMoreButton.Click();
        }

        public void ClickShowLessButton()
        {
            Wait.WaitToBEClickable(driver, "XPath", "//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[11]/div[1]/center/a", 5);
            notificationComponentObj.ShowlessButton.Click();
        }

        public void ClickSelectAllButton()
        {
            notificationComponentObj.SelectAllButton.Click();
        }

        public void ClickUnselectAllButton()
        {
            notificationComponentObj.UnselectAllButton.Click();
        }

        public void ClickDeleteSelectedButton()
        {
            notificationComponentObj.DeleteSelectedButton.Click();
        }

        public void ClickMarkSelectedAsReadButton()
        {
            notificationComponentObj.MarkSelectionAsReadButton.Click();
        }
    }
}
