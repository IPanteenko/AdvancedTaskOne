using AdvancedTask1.Pages.HomePage.Components;
using AdvancedTask1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AdvancedTask1.Model.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Pages.HomePage
{
    public class SkillsTabPage
    {
        private readonly IWebDriver driver;
        private readonly SkillsComponent skillsComponent;

        public SkillsTabPage(IWebDriver driver)
        {
            this.driver = driver;
            skillsComponent = new SkillsComponent(driver);
        }

        public void RemoveExistingSkills()
        {
            Wait.WaitIsVisible(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table", 7);

            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

            while (skillsComponent.DeleteSkillButton != null)
            {
                var rowCount = driver.FindElements(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody")).Count;
              skillsComponent.DeleteSkillButton.Click();
                wait.Until((driver) =>
                {
                    var updatedRowCount = driver.FindElements(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody")).Count;
                    return updatedRowCount == rowCount - 1;
                });
            }
        }

        public void ClickAddNewSkillButton()
        {
            Wait.WaitIsVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 5);
            skillsComponent.AddNewSkillButton.Click();
        }

        public void EnterSkillName(Skills skill)
        {
            skillsComponent.AddSkillTextBox.SendKeys(skill.SkillName);
        }

        public void EnterSkillLevel(Skills skill)
        {
            SelectElement skillLevelDropDown = new SelectElement(skillsComponent.SkillLevelDropDown);
            skillLevelDropDown.SelectByValue(skill.SkillLevel);
        }

        public void ClickAddSkillButton()
        {
            skillsComponent.AddSkillButton.Click();
        }

        public void DeleteSkill()
        {
            Wait.WaitToBEClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]", 5);
            skillsComponent.DeleteSkillButton.Click();

            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.StalenessOf(skillsComponent.DeleteSkillButton));
        }

        public void ClickEditButton()
        {
            Wait.WaitIsVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i", 10);
            skillsComponent.EditSkillButton.Click();
        }

         public void EditSkillName(Skills skill)
        {
            skillsComponent.EditSkillTextBox.Clear();
            skillsComponent.EditSkillTextBox.SendKeys(skill.SkillName);
        }

        public void EditSkillLevel(Skills skill)
        {
            SelectElement editskillLevelDropDown = new SelectElement(skillsComponent.EditSkillLevelDropDown);
            editskillLevelDropDown.SelectByValue(skill.SkillLevel);
        }

        public void ClickUpdateButton()
        {
            skillsComponent.UpdateSkillButton.Click();
        }

        public void ClickCancelSkillAddition()
        {
            skillsComponent.CancelAdditionButton.Click();
        }

        public void ClickCancelEditButton()
        {
            skillsComponent.CancelEditButton.Click();
        }
    }
}
