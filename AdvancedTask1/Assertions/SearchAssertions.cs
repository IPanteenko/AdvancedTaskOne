using AdvancedTask1.Pages.SearchPage;
using AdvancedTask1.Pages.SearchPage.Component;
using AdvancedTask1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Assertions
{
    internal class SearchAssertions
    {
        public readonly IWebDriver driver;
        public readonly SearchComponent searchComponentObj;
        public readonly SearchPage searchPageObj;

        public SearchAssertions(IWebDriver driver)
        {
            this.driver = driver;
            searchComponentObj = new SearchComponent(driver);
            searchPageObj = new SearchPage(driver);
        }

        public void AssertListingsWereFound()
        {
            Wait.WaitIsVisible(driver, "XPath", "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div", 10);
            Assert.That(searchComponentObj.Listings.Displayed, "Listings weren't found");
        }
        public void AssertListingIsNotFoundInWrongCategory()
        {
            Wait.WaitToBEClickable(driver, "XPath", "//*[@class=\"search-results\"]/div/div[1]/div[2]/i", 5);
            searchComponentObj.SearchSkillButton.Click();
            Wait.WaitIsVisible(driver, "ZPath", "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div", 5);
            Assert.That(searchComponentObj.NoResultsFound.Displayed, "Listing were found");
        }
    }
}
