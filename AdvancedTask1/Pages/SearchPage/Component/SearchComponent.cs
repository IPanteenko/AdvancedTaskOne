using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V85.Profiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Pages.SearchPage.Component
{
    public class SearchComponent
    {
        public readonly IWebDriver driver;
        public SearchComponent(IWebDriver driver)
        {
        this.driver = driver;
        }

        public IWebElement BusinessCategoryButton => driver.FindElement(By.XPath("//*[@class=\"search-results\"]/div/div[1]/div[1]/div/a[8]"));
        public IWebElement MarketingCategoryButton => driver.FindElement(By.XPath("//*[@class=\"search-results\"]/div/div[1]/div[1]/div/a[3]"));                                                                                  
        public IWebElement OnlineFilterButton => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[3]/div/section/div/div[1]/div[5]/button[1]"));
        public IWebElement SocialMarketingSubCategoryButton => driver.FindElement(By.XPath("//*[@class=\"search-results\"]/div/div[1]/div[1]/div/a[3]"));
        public IWebElement EmailMarketingSubCategoryButton => driver.FindElement(By.XPath("//*[@class=\"search-results\"]/div/div[1]/div[1]/div/a[7]"));
        public IWebElement SearchSkillTextBox => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[2]/input"));
        public IWebElement SearchSkillButton => driver.FindElement(By.XPath("//*[@class=\"search-results\"]/div/div[1]/div[2]/i")); 
        public IWebElement NoResultsFound => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div"));
        public IWebElement Listings => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div"));
    }
}
