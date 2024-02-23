using AdvancedTask1.Model.ShareSkill;
using AdvancedTask1.Model.Skills;
using AdvancedTask1.Pages.ShareSkillPage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Steps
{
    public class ShareSkillSteps
    {
        public readonly ShareSkillPage shareSkillPageObj;

        public ShareSkillSteps(IWebDriver driver)
        {
            shareSkillPageObj= new ShareSkillPage(driver);
        }

        public void ShareValidSkill(ShareSkill skill)
        {

            shareSkillPageObj.EnterSkillTitle(skill);
            shareSkillPageObj.EnterSkillDescription(skill);
            shareSkillPageObj.SelectSkillCategory(skill);
            shareSkillPageObj.SelectSkillSubcategory(skill);
            shareSkillPageObj.EnterSkillTags(skill);
            shareSkillPageObj.SetStartDate(skill);
            shareSkillPageObj.SetEndDate(skill);
            shareSkillPageObj.ClickCraditRadioButton();
            shareSkillPageObj.EnterCreditAmount(skill);
            shareSkillPageObj.ClickSaveButton();
        }

        public void ShareSkillWithoutTitle(ShareSkill skill)
        {
            shareSkillPageObj.EnterSkillDescription(skill);
            shareSkillPageObj.SelectSkillCategory(skill);
            shareSkillPageObj.SelectSkillSubcategory(skill);
            shareSkillPageObj.EnterSkillTags(skill);
            shareSkillPageObj.ClickCraditRadioButton();
            shareSkillPageObj.EnterCreditAmount(skill);
            shareSkillPageObj.ClickSaveButton();
        }

        public void ShareSkillWithoutDescription(ShareSkill skill)
        {

            shareSkillPageObj.EnterSkillTitle(skill);
            shareSkillPageObj.SelectSkillCategory(skill);
            shareSkillPageObj.SelectSkillSubcategory(skill);
            shareSkillPageObj.EnterSkillTags(skill);
            shareSkillPageObj.ClickCraditRadioButton();
            shareSkillPageObj.EnterCreditAmount(skill);
            shareSkillPageObj.ClickSaveButton();
        }

        public void ShareSkillWithoutCategory(ShareSkill skill)
        {

            shareSkillPageObj.EnterSkillTitle(skill);
            shareSkillPageObj.EnterSkillDescription(skill);
            shareSkillPageObj.EnterSkillTags(skill);
            shareSkillPageObj.ClickCraditRadioButton();
            shareSkillPageObj.EnterCreditAmount(skill);
            shareSkillPageObj.ClickSaveButton();
        }

        public void ShareSkillWithoutSubCategory(ShareSkill skill)
        {
            shareSkillPageObj.EnterSkillTitle(skill);
            shareSkillPageObj.EnterSkillDescription(skill);
            shareSkillPageObj.SelectSkillCategory(skill);
            shareSkillPageObj.EnterSkillTags(skill);
            shareSkillPageObj.ClickCraditRadioButton();
            shareSkillPageObj.EnterCreditAmount(skill);
            shareSkillPageObj.ClickSaveButton();
        }

        public void ShareSkillWithoutTag(ShareSkill skill)
        {
            shareSkillPageObj.EnterSkillTitle(skill);
            shareSkillPageObj.EnterSkillDescription(skill);
            shareSkillPageObj.SelectSkillCategory(skill);
            shareSkillPageObj.SelectSkillSubcategory(skill);
            shareSkillPageObj.ClickCraditRadioButton();
            shareSkillPageObj.EnterCreditAmount(skill);
            shareSkillPageObj.ClickSaveButton();
        }

    }
}

