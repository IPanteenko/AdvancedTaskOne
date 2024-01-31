using AdvancedTask1.Model.ShareSkill;
using AdvancedTask1.Pages.HomePage.Components;
using AdvancedTask1.Pages.ShareSkillPage.Component;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedTask1.Utilities;

namespace AdvancedTask1.Pages.ShareSkillPage
{
    public class ShareSkillPage
    {
        private readonly IWebDriver driver;
        private readonly ShareSkillFormComponent shareSkillFormComponent;

        public ShareSkillPage(IWebDriver driver)
        {
            this.driver = driver;
            shareSkillFormComponent = new ShareSkillFormComponent(driver);
        }

        public void EnterSkillTitle(ShareSkill skill)
        {
            Wait.WaitToBEClickable(driver, "XPAth", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input", 10);
            shareSkillFormComponent.TitleTextbox.SendKeys(skill.Title);
        }

        public void EnterSkillDescription(ShareSkill skill)
        {
            shareSkillFormComponent.DescriptionTextbox.SendKeys(skill.Description);
        }

        public void SelectSkillCategory(ShareSkill skill)
        {
            SelectElement skillCategoryDropDown = new SelectElement(shareSkillFormComponent.CategoryDropdown);
            skillCategoryDropDown.SelectByValue(skill.Category);
        }

        public void SelectSkillSubcategory(ShareSkill skill)
        {
            SelectElement skillSubcategoryDropDown = new SelectElement(shareSkillFormComponent.SubCategoryDropDown);
            skillSubcategoryDropDown.SelectByValue(skill.Subcategory);
        }

        public void EnterSkillTags(ShareSkill skill)
        {
            shareSkillFormComponent.TagTextbox.SendKeys(skill.Tags + Keys.Enter);
        }

        public void ClickCraditRadioButton()
        {
            shareSkillFormComponent.CreditRadioButton.Click();
        }

        public void EnterCreditAmount(ShareSkill skill)
        {
            shareSkillFormComponent.CreditTextBox.SendKeys(skill.Credit);
        }

        public void ClickSaveButton()
        {
            shareSkillFormComponent.SaveButton.Click();
        }

        public void SetStartDate(ShareSkill skill)
        {
            shareSkillFormComponent.StartDateBox.SendKeys(skill.StartDate);
        }

        public void SetEndDate(ShareSkill skill) 
        {
            shareSkillFormComponent.EndDateBox.SendKeys(skill.EndDate);
        }
    }
}
