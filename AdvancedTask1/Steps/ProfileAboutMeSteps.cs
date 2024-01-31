using AdvancedTask1.Pages.HomePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Steps
{
    internal class ProfileAboutMeSteps
    {
        private readonly ProfileAboutMe profileAboutMeObj;

        public ProfileAboutMeSteps(IWebDriver driver)
        {
            profileAboutMeObj = new ProfileAboutMe(driver);
        }

        public void SetAvailability(string availability)
        {
            profileAboutMeObj.ClickEditAvailability();
            profileAboutMeObj.SelectAvailabilityInProfile(availability);
        }

        public void SetHours(string hours)
        {
            profileAboutMeObj.ClickEditHours();
            profileAboutMeObj.SelectHoursInProfile(hours);
        }

        public void SetEarningTarget(string earnTarget)
        {
            profileAboutMeObj.ClickEarnTargetButton();
            profileAboutMeObj.SelectEarnTargetInProfile(earnTarget);
        }

        public void CancelAvailabilityEdit()
        {
            profileAboutMeObj.ClickEditAvailability();
            profileAboutMeObj.ClickCancelAvailabilityEditButton();
        }

        public void CancelHoursEdit() 
        {
            profileAboutMeObj.ClickEditHours();
            profileAboutMeObj.ClickCancelHoursEditButton();
        }

        public void CancelEarnTargetEdit()
        {
            profileAboutMeObj.ClickEarnTargetButton();
            profileAboutMeObj.ClickCancelEarnTargetEditButton();
        }
    }
}
