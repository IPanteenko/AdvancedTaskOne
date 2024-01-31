using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Pages.Components
{
    public class NavigationMenuComponent
    {
        public IWebDriver driver;

        public NavigationMenuComponent(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement DashBoardButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[1]"));
    }
}
