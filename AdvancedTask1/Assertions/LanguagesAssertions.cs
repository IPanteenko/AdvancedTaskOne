using AdvancedTask1.Model.Languages;
using AdvancedTask1.Pages.HomePage;
using AdvancedTask1.Pages.HomePage.Components;
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
    internal class LanguagesAssertions
    {
        public readonly IWebDriver driver;
        public readonly LanguagesComponent languagesComponentObj;
        public readonly MessagePopUpPage messagePopUpPageObj;

        public LanguagesAssertions(IWebDriver driver)
        {
            this.driver = driver;
            languagesComponentObj = new LanguagesComponent(driver);
            messagePopUpPageObj = new MessagePopUpPage(driver);
        }

        public void AssertActualLanguageMatchesCreated(Languages language)
        {
            Wait.WaitIsVisible(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr", 10);
            Assert.That(languagesComponentObj.NewLanguageName.Text == language.LanguageName, "Actual and Created Language names don't match");
            Assert.That(languagesComponentObj.NewLanguageLevel.Text == language.LanguageLevel, "Actual and Created Language level don't match");
        }

        public void AssertThatLanguageWasDeleted()
        {
            Assert.That(languagesComponentObj.LanguageRecord == null, "Record is present");
        }

        public void AssertThatLanguageAdditionWasCancelled()
        {
            Assert.That(languagesComponentObj.LanguageSection == null, "Addition wasn't cancelled");
        }

        public void AssertThatUpdateWasCancelled()
        {
            Assert.That(languagesComponentObj.UpdateButton == null, "Add new button is present");
        }

        public void AssertThatDeleteButtonIsNotPresent()
        {
            Assert.That(languagesComponentObj.DeleteButton == null, "Delete Button is present");
        }

        public void AssertThatEditbuttonIsNotPresent()
        {
            Assert.That(languagesComponentObj.EditButton == null, "Edit Button Is present");
        }

        public void AssertAdditionWithEmptyFieldUnsuccessful()
        {
            var errorMessage = messagePopUpPageObj.FindErrorMessagePopUp("Please enter language and level");
            Assert.That(errorMessage.Displayed, "Error Message doesn't pop up");
        }
    }
}
