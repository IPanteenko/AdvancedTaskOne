using AdvancedTask1.Model.Languages;
using AdvancedTask1.Pages.HomePage;
using OpenQA.Selenium;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Steps
{
    public class LanguagesTabSteps
    {
        private readonly LanguagesTabPage languagesTabPage;

        public LanguagesTabSteps(IWebDriver driver)
        {
            languagesTabPage = new LanguagesTabPage(driver);
        }

        public void LanguagesDataReset()
        {
            languagesTabPage.RemoveExistingLanguages();
        }

        public void AddNewLanguage(Languages language)
        {
            languagesTabPage.ClickAddNewLanguageButton();
            languagesTabPage.EnterLnguageName(language);
            languagesTabPage.ChooseLanguageLevel(language);
            languagesTabPage.ClickAddButton();
        }

        public void AddLanguageWithoutName(Languages language) 
        {
            languagesTabPage.ClickAddNewLanguageButton();
            languagesTabPage.ChooseLanguageLevel(language);
            languagesTabPage.ClickAddButton();
        }

        public void AddLanguageWithoutLevel(Languages language) 
        {
            languagesTabPage.ClickAddNewLanguageButton();
            languagesTabPage.EnterLnguageName(language);
            languagesTabPage.ClickAddButton();
        }

        public void EditLanguage(Languages language) 
        {
            languagesTabPage.ClickEditButton();
            languagesTabPage.EditLanguageName(language);
            languagesTabPage.EditLanguageLevel(language);
            languagesTabPage.ClickUpdateButton();
        }

        public void CancelLanguageAddition(Languages language)
        {
            languagesTabPage.ClickAddNewLanguageButton();
            languagesTabPage.EnterLnguageName(language);
            languagesTabPage.ChooseLanguageLevel(language);
            languagesTabPage.ClickCancelAdditionButton();
        }

        public void CancelLanguageEdit()
        {
            languagesTabPage.ClickEditButton();
            languagesTabPage.ClickCancelEditButton();
        }

        public void DeleteLanguageRecord()
        {
            languagesTabPage.DeleteLanguage();
        }

    }
}
