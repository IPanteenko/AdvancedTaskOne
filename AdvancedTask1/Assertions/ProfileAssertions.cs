using AdvancedTask1.Pages.HomePage;
using AdvancedTask1.Pages.HomePage.Components;
using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedTask1.TestData.Enums;
using SeleniumExtras.WaitHelpers;

namespace AdvancedTask1.Assertions
{
    internal class ProfileAssertions
    {
        private readonly IWebDriver driver;
        private readonly ProfileAboutMeComponent profileAboutMeComponentObj;
        private readonly ProfileAboutMe profileAboutMeObj;

        public ProfileAssertions(IWebDriver driver)
        {
            this.driver = driver;
            profileAboutMeComponentObj = new ProfileAboutMeComponent(driver);
            profileAboutMeObj = new ProfileAboutMe(driver);
        }

        public void AssertThatSetAviabiliityMatchesActualAvailability(string availability)
        {
            Assert.That(profileAboutMeComponentObj.AvailabilityText == availability, "Set Availability and actual Availability don't match");
        }

        public void AssertThatSetHoursMatchesActualHours(string hours)
        {
            Assert.That(profileAboutMeComponentObj.HoursText == hours, "Set Hours and Actual hours don't match");
        }

        public void AssertThatSetEarnTargetMatchesActual(string earnTarget)
        {
            Assert.That(profileAboutMeComponentObj.EarnTargetText == earnTarget, "Set and Actual EarnTarget don't match");
        }

        public void AssertAvailabilityEditWasCancelled()
        {
            Assert.That(profileAboutMeComponentObj.AvailabilityDropDown == null, "Availability Edit Wasn't cancelled");
        }

        public void AssertHoursEditWasCancelled()
        {
            Assert.That(profileAboutMeComponentObj.HoursDropDown == null, "Hours Edit wasn't cancelled");
        }

        public void AssertEarnTargetEditWasCancelled()
        {
            Assert.That(profileAboutMeComponentObj.EarnTargetDropDown == null, "Earn Target Edit wasn't cancelled");
        }
    }
}
