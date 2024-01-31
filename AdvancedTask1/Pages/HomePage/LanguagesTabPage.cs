using AdvancedTask1.Model.Languages;
using AdvancedTask1.Pages.HomePage.Components;
using AdvancedTask1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AdvancedTask1.Pages.HomePage
{
    public class LanguagesTabPage
    {
        private readonly IWebDriver driver;
        private readonly LanguagesComponent languagesComponent;

        public LanguagesTabPage(IWebDriver driver)
        {
            this.driver = driver;
            languagesComponent = new LanguagesComponent(driver);
        }

        public void RemoveExistingLanguages()
        {
            Wait.WaitIsVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table", 7);
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

            while (languagesComponent.DeleteButton != null)
            {
                var rowCount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody")).Count;
                languagesComponent.DeleteButton.Click();
                wait.Until((driver) =>
                {
                    var updatedRowCount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody")).Count;
                    return updatedRowCount == rowCount - 1;
                });
            }
        }

        public void ClickAddNewLanguageButton()
        {
            Wait.WaitIsVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table", 7);
            languagesComponent.AddNewButton.Click();
        }

        public void EnterLnguageName(Languages language)
        {
            languagesComponent.AddLanguageTextBox.SendKeys(language.LanguageName);      
        }

        public void ChooseLanguageLevel(Languages language)
        {
            SelectElement languageLevel= new SelectElement(languagesComponent.LanguageLevelDropDown);
            languageLevel.SelectByValue(language.LanguageLevel);
        }

        public void ClickAddButton()
        {
            languagesComponent.AddButton.Click();
        }

        public void DeleteLanguage()
        {
            Wait.WaitToBEClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]", 10);
            languagesComponent.DeleteButton.Click();
        }

        public void ClickEditButton()
        {
            Wait.WaitIsVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr", 7);
            languagesComponent.EditButton.Click();
        }

        public void EditLanguageName(Languages languages)
        {
            languagesComponent.EditLanguageTextBox.Clear();
            languagesComponent.EditLanguageTextBox.SendKeys(languages.LanguageName);
        }

        public void EditLanguageLevel(Languages languages)
        {
            SelectElement editLanguageLevelDropdown = new SelectElement (languagesComponent.EditLanguageDropDown);
            editLanguageLevelDropdown.SelectByValue(languages.LanguageLevel);
        }

        public void ClickUpdateButton()
        {
            languagesComponent.UpdateButton.Click();
        }

        public void ClickCancelAdditionButton()
        {
            languagesComponent.CancelAdditionButton.Click();
        }

        public void ClickCancelEditButton()
        {
            languagesComponent.CancelEditButton.Click();
        }


    }
}
