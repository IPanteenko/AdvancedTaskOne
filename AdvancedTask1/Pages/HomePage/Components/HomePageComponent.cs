using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Pages.HomePage.Components
{
    public class HomePageComponent
    {
        private readonly IWebDriver driver;

        public HomePageComponent (IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement SKillTabButton => driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        public IWebElement ShareSkillButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));
        public IWebElement SearchButton => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[1]/div[1]/i"));
    }

}
