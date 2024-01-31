using AdvancedTask1.Model.ShareSkill;
using AdvancedTask1.Pages.SearchPage.Component;
using AdvancedTask1.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Pages.SearchPage
{
    public class SearchPage
    {
        private readonly IWebDriver driver;
        private readonly SearchComponent searchComponent;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            searchComponent = new SearchComponent(driver);
        }

       

        public void SelectBusinessCategory()
        {
            Wait.WaitToBEClickable(driver, "XPath", "//*[@class=\"search-results\"]/div/div[1]/div[1]/div/a[8]", 10);
            searchComponent.BusinessCategoryButton.Click();
        }

        public void SelectRightCategory()
        {
            // Wait.WaitIsVisible(driver, "XPath", "//*[@class=\"search-results\"]/div/div[1]/div[1]/div/a[3]", 10);
            Wait.WaitToBEClickable(driver, "XPath", "//*[@class=\"search-results\"]/div/div[1]/div[1]/div/a[3]", 10);
            searchComponent.MarketingCategoryButton.Click();
        }


        public void SelectEmailMarketingCategory()
        { 
            searchComponent.EmailMarketingSubCategoryButton.Click();
        }

        public void SelectSocialMarketingCategory()
        { 
            searchComponent.SocialMarketingSubCategoryButton.Click();
        }

        public void UseOnlineFilter()
        {
            searchComponent.OnlineFilterButton.Click();
        }

        public void SearchSkill(ShareSkill skill)
        {
            searchComponent.SearchSkillTextBox.SendKeys(skill.Title + Keys.Enter);
            Wait.WaitToBEClickable(driver, "XPath", "//*[@class=\"search-results\"]/div/div[1]/div[2]/i", 5);
            searchComponent.SearchSkillButton.Click();
        }

        
    }
}
