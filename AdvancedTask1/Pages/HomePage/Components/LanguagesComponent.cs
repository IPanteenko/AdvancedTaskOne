using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Pages.HomePage.Components
{
    public class LanguagesComponent
    {
        public readonly IWebDriver driver;

        public LanguagesComponent (IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement AddNewButton => driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).FirstOrDefault();
        public IWebElement AddLanguageTextBox => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
        public IWebElement AddButton => driver.FindElements(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]")).FirstOrDefault();
        public IWebElement NewLanguageName => driver.FindElement(By.XPath("//tbody/tr/td[1]"));
        public IWebElement NewLanguageLevel => driver.FindElement(By.XPath("//tbody/tr/td[2]"));
        public IWebElement DeleteButton => driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]")).FirstOrDefault();
        public IWebElement EditButton => driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]")).FirstOrDefault();
        public IWebElement EditLanguageTextBox => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));
        public IWebElement UpdateButton => driver.FindElements(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]")).FirstOrDefault();
        public IWebElement CancelAdditionButton => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[2]"));
        public IWebElement CancelEditButton => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[2]"));
        public IWebElement LanguageSection => driver.FindElements(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div")).FirstOrDefault();
        public IWebElement LanguageRecord => driver.FindElements(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr")).FirstOrDefault();
        public IWebElement LanguageLevelDropDown => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
        public IWebElement EditLanguageDropDown => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]"));
    
    }
}
