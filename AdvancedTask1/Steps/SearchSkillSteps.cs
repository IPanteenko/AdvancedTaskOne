using AdvancedTask1.Model.ShareSkill;
using AdvancedTask1.Model.Skills;
using AdvancedTask1.Pages.SearchPage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Steps
{
    internal class SearchSkillSteps
    {
        public readonly SearchPage searchPageObj;

        public SearchSkillSteps(IWebDriver driver)
        {
            searchPageObj = new SearchPage(driver);
        }

        public void SearchSkillInWrongCategory(ShareSkill skill)
        {
            searchPageObj.SelectBusinessCategory();
            searchPageObj.SearchSkill(skill);
        }
        public void SearchSkillInMarketingCategory(ShareSkill skill)
        {
            searchPageObj.SelectRightCategory();
            searchPageObj.SearchSkill(skill);
        }

        public void SearchSkillInWrongSubcategory(ShareSkill skill)
        {
            searchPageObj.SelectRightCategory();
            searchPageObj.SelectEmailMarketingCategory();
            searchPageObj.SearchSkill(skill);
        }
                    
        public void SearchSkillInRightSubcategory(ShareSkill skill) 
        {
            searchPageObj.SelectRightCategory();
            searchPageObj.SelectSocialMarketingCategory();
            searchPageObj.SearchSkill(skill);
        }

        public void FindOnlineListings(ShareSkill skill)
        {
            searchPageObj.UseOnlineFilter();
            searchPageObj.SearchSkill(skill);
        }

    }
}
