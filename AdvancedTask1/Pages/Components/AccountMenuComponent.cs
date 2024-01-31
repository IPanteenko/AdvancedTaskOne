using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Pages.Components
{
    public class AccountMenuComponent
    {
        public IWebDriver driver;

        public AccountMenuComponent(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement NotificationDropDown => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/div/i[2]"));
        public IWebElement SeeAllNotifications => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/div/div[2]/span/div/div[2]/div/center/a"));
        public IWebElement MarkAllAsReadButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/div/div[2]/span/div/div[1]/div[1]/center/a"));
        public IWebElement SignOutButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
    }
}
