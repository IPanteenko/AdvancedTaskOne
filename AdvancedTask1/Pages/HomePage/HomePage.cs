using AdvancedTask1.Pages.HomePage.Components;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AdvancedTask1.TestData.Enums;
using OpenQA.Selenium.Support.UI;
using AdvancedTask1.Utilities;
using System.Security.Cryptography.X509Certificates;

namespace AdvancedTask1.Pages.HomePage
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        private readonly HomePageComponent homePageComponent;

        public HomePage(IWebDriver driver)
        { 
            this.driver = driver;
            homePageComponent = new HomePageComponent(driver);
        }

        public void ClickSkillTabButton()
        {
            Wait.WaitIsVisible(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]", 10);
            homePageComponent.SKillTabButton.Click();
        }

        public void ClickShareSkillButton()
        {
            Wait.WaitIsVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span", 10);
            homePageComponent.ShareSkillButton.Click();
        }

        public void ClickSearchButton()
        
        {
            Wait.WaitIsVisible(driver, "XPath", "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table", 5);

            homePageComponent.SearchButton.Click();
        }

        
    }
}
