using AdvancedTask1.Pages.HomePage.Components;
using AdvancedTask1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Pages.HomePage
{
    internal class ProfileAboutMe
    {
        private readonly IWebDriver driver;
        private readonly ProfileAboutMeComponent profileAboutMeComponentObj;

        public ProfileAboutMe(IWebDriver driver)
        {
            this.driver = driver;
            profileAboutMeComponentObj = new ProfileAboutMeComponent(driver);
        }


        public void ClickEditAvailability()
        {
            Wait.WaitToBEClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i", 10);
            profileAboutMeComponentObj.EditAvailabilityButton.Click();
        }
        public void SelectAvailabilityInProfile(string availability)
        {

            SelectElement availabilityDropDown = new SelectElement(profileAboutMeComponentObj.AvailabilityDropDown);
            availabilityDropDown.SelectByValue(availability);
        }

        public void ClickEditHours()
        {
            Wait.WaitToBEClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i", 6);
            profileAboutMeComponentObj.EditHoursButton.Click();
        }

        public void SelectHoursInProfile(string hours)
        {
            SelectElement hoursDropDown = new SelectElement(profileAboutMeComponentObj.HoursDropDown);
            hoursDropDown.SelectByValue(hours);
        }

        public void ClickEarnTargetButton()
        {
            Wait.WaitToBEClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i", 5);
            profileAboutMeComponentObj.EditEarnTargetButton.Click();
        }

        public void SelectEarnTargetInProfile(string earnTarget)
        {
            SelectElement earnTargetDropDown = new SelectElement(profileAboutMeComponentObj.EarnTargetDropDown);
            earnTargetDropDown.SelectByValue(earnTarget);
        }

        public void ClickCancelAvailabilityEditButton()
        {
            profileAboutMeComponentObj.CancelAvailabilityButton.Click();
        }

        public void ClickCancelHoursEditButton()
        {
            profileAboutMeComponentObj.CancelHoursButton.Click();
        }

        public void ClickCancelEarnTargetEditButton()
        {
            profileAboutMeComponentObj.CancelEarnTargetButton.Click();
        }
    }
}
