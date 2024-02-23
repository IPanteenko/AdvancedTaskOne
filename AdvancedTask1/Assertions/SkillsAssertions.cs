using AdvancedTask1.Model.Skills;
using AdvancedTask1.Pages.HomePage;
using AdvancedTask1.Pages.HomePage.Components;
using AdvancedTask1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdvancedTask1.Assertions
{
    internal class SkillsAssertions
    {
        public readonly IWebDriver driver;
        private readonly SkillsComponent skillsComponentObj;
        private readonly MessagePopUpPage messagePopUpPageObj;

        public SkillsAssertions(IWebDriver driver)
        {
            this.driver = driver;
            skillsComponentObj = new SkillsComponent(driver);
            messagePopUpPageObj = new MessagePopUpPage(driver);
        }   

        public void AssertThatActuaAndCreatedRecordsMatch(Skills skill)
        {
            Wait.WaitIsVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]", 10);
            Assert.That(skillsComponentObj.NewSkillName.Text == skill.SkillName , "Actual name and created name don't match");
            Assert.That(skillsComponentObj.NewSkillLevel.Text == skill.SkillLevel, "Actual level and created level don't match");
        }

        public void AssertThatSkillRecordWasDeleted()
        {
            Assert.That(skillsComponentObj.SkillRecord == null, "The record is present");
        }

        public void AssertThatDeleteButtonIsNotPresent()
        {
            Assert.That(skillsComponentObj.DeleteSkillButton == null, "Delete button is present");
        }

        public void AssertThatEditButtonIsNotPresent()
        {
            Assert.That(skillsComponentObj.EditSkillButton == null, "Edit Button is Present");
        }

        public void AssertThatSkillAdditionWasCancelled()
        {
            Assert.That(skillsComponentObj.AddNewSkillSection == null, "The addition of the skill record wasn't canceled");
        }

        public void AssertThatSkillEditWasCancelled()
        {
            Assert.That(skillsComponentObj.UpdateSkillButton == null, "Update button is present");
        }

        public void AssertAdditionWasUnsuccessfull()
        {
            var errorMessage = messagePopUpPageObj.FindErrorMessagePopUp("Please enter skill and experience level");
            Assert.That(errorMessage.Displayed, "Error Message doesn't pop up");
        }

        public void AssertEditWasSuccessful(Skills skill)
        {
            Wait.WaitElementIsStail(driver, skillsComponentObj.UpdateSkillButton);
            Assert.That(skillsComponentObj.NewSkillName.Text == skill.SkillName, "Actual name and created name don't match");
            Assert.That(skillsComponentObj.NewSkillLevel.Text == skill.SkillLevel, "Actual level and created level don't match");

        }
    }
}
