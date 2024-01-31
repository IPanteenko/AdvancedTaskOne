using AdvancedTask1.Model.Skills;
using AdvancedTask1.Pages.HomePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Steps
{
    public class SkillsTabSteps
    {
        private readonly SkillsTabPage skillsTabPageObj;

        public SkillsTabSteps(IWebDriver driver)
        {
            skillsTabPageObj = new SkillsTabPage(driver);
        }

        public void SkillsDataReset()
        {
            skillsTabPageObj.RemoveExistingSkills();
        }

        public void AddNewSkill(Skills skill)
        {
            skillsTabPageObj.ClickAddNewSkillButton();
            skillsTabPageObj.EnterSkillName(skill);
            skillsTabPageObj.EnterSkillLevel(skill);
            skillsTabPageObj.ClickAddSkillButton();
        }

        public void AddSkillWithoutName(Skills skill)
        {
            skillsTabPageObj.ClickAddNewSkillButton();
            skillsTabPageObj.EnterSkillLevel(skill);
            skillsTabPageObj.ClickAddSkillButton();
        }

        public void AddSkillWithoutLevel(Skills skill)
        {
            skillsTabPageObj.ClickAddNewSkillButton();
            skillsTabPageObj.EnterSkillName(skill);
            skillsTabPageObj.ClickAddSkillButton();
        }

        public void EditSkill(Skills skill)
        {
            skillsTabPageObj.ClickEditButton();
            skillsTabPageObj.EditSkillName(skill);
            skillsTabPageObj.EditSkillLevel(skill);
            skillsTabPageObj.ClickUpdateButton();
        }

        public void DeleteSkill()
        {
            skillsTabPageObj.DeleteSkill();
        }

        public void CancelNewSkillAddition(Skills skill)
        {
            skillsTabPageObj.ClickAddNewSkillButton();
            skillsTabPageObj.EnterSkillName(skill);
            skillsTabPageObj.EnterSkillLevel(skill);
            skillsTabPageObj.ClickCancelSkillAddition();
        }

        public void CancelSkillEdit(Skills skill)
        {
            skillsTabPageObj.ClickEditButton();
            skillsTabPageObj.EditSkillName(skill);
            skillsTabPageObj.EditSkillLevel(skill);
            skillsTabPageObj.ClickCancelEditButton();
        }
    }
}

