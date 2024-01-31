using AdvancedTask1.Model.ShareSkill;
using AdvancedTask1.Pages.HomePage;
using AdvancedTask1.Pages.ShareSkillPage;
using AdvancedTask1.Pages.ShareSkillPage.Component;
using AdvancedTask1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Assertions
{
    internal class ShareSkillAssertions
    {
        public readonly IWebDriver driver;
        public readonly ShareSkillPage shareSkillPageObj;
        public readonly ShareSkillFormComponent shareSkillFormComponent;
        public readonly MessagePopUpPage messagePopUpPageObj;

        public ShareSkillAssertions(IWebDriver driver)
        {
            this.driver = driver;
            shareSkillPageObj = new ShareSkillPage(driver);
            shareSkillFormComponent = new ShareSkillFormComponent(driver); 
            messagePopUpPageObj = new MessagePopUpPage(driver);
        }

        public void AssertSharedSkillMatchesActualSkill(ShareSkill skill)
        {
            Wait.WaitIsVisible(driver, "XPath", "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table", 5);
            Assert.That(shareSkillFormComponent.CreatedTitle == skill.Title, "Created title and Actual Title dont match");
        }

        public void AssertErrorMessageIsDisplayed()
        {
            var errorMassage = messagePopUpPageObj.FindErrorMessagePopUp("Please complete the form correctly.");
            Assert.That(errorMassage.Displayed, "Error message is not displayed");
        }

        public void AssertAmountOfCharactersInTitle()
        {
            Wait.WaitIsVisible(driver, "XPath", "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table", 5);
            Assert.That(shareSkillFormComponent.CreatedTitle.Length < 100, "Characters Limit in Title doen't work");
        }

        public void AssertAmountOfCharactersInDescription()
        {
            Wait.WaitIsVisible(driver, "XPath", "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table", 5);
            Assert.That(shareSkillFormComponent.CreatedDescription.Length < 600, "Characters Limit in Title doen't work");
        }

        public void AssertSpecialCharactersNotificationInTitlePresent()
        {
            Assert.That(shareSkillFormComponent.SpecialCharactersInTitleNotification.Displayed, "Spacial characters notification is not displayed");
        }


        public void AssertSpecialCharactersNotificationInDescriptionPresent()
        {
            Assert.That(shareSkillFormComponent.SpecialCharactersInDescriptionNotification.Displayed, "Spacial characters notification is not displayed");
        }

        public void AssertStartEndDateNotificationPresent()
        {
            Assert.That(shareSkillFormComponent.StartEndDateNotification.Displayed, "Notification is not displayed");
        }
    }
}
