using AdvancedTask1.Assertions;
using AdvancedTask1.Reports;
using AdvancedTask1.Steps;
using AdvancedTask1.TestData.Enums;
using AdvancedTask1.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Tests
{
    [TestFixture]
    internal class ProfileTests: CommonDriver
    {
        private SignInSteps signInStepsObj;
        private ProfileAboutMeSteps profileAboutMeStepsObj;
        private ProfileAssertions profileAssertionsObj;
        private ReportWriter reportWriter;

        public void CreatePageObjects()
        {
            signInStepsObj= new SignInSteps(driver);
            profileAboutMeStepsObj = new ProfileAboutMeSteps(driver);
            profileAssertionsObj = new ProfileAssertions(driver);
        }

        public void CreateReporter()
        {
            reportWriter = new ReportWriter(nameof(ProfileTests));
        }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            CreateReporter();
        }

        [SetUp]
        public void Setup()
        {
            OpenPortal();
            CreatePageObjects();
            reportWriter.InitialiseTestRun(TestContext.CurrentContext.Test.Name);
            reportWriter.AddScreenshotTaker(driver);
            signInStepsObj.PortalSignIn();
        }

        [Test]
        public void ChangeAvailability()
        {
            profileAboutMeStepsObj.SetAvailability(Availability.PartTime.Value.ToString());
            profileAssertionsObj.AssertThatSetAviabiliityMatchesActualAvailability(Availability.PartTime.DisplayText);
        }
        
        [Test]
        public void ChangeHours()
        {
            profileAboutMeStepsObj.SetHours(Hours.AsNeeded.Value.ToString());
            profileAssertionsObj.AssertThatSetHoursMatchesActualHours(Hours.AsNeeded.DisplayText);
        }

        [Test]
        public void ChangeEarnTarget() 
        {
            profileAboutMeStepsObj.SetEarningTarget(EarnTarget.Between.Value.ToString());
            profileAssertionsObj.AssertThatSetEarnTargetMatchesActual(EarnTarget.Between.DisplayText);
        }

        [Test]
        public void CancelAvailabilityEdit()
        {
            profileAboutMeStepsObj.CancelAvailabilityEdit();
            profileAssertionsObj.AssertAvailabilityEditWasCancelled();
        }

        [Test]
        public void CancelHoursEdit()
        {
            profileAboutMeStepsObj.CancelHoursEdit();
            profileAssertionsObj.AssertHoursEditWasCancelled();
        }

        [Test]
        public void CancelEarnTargetEdit() 
        {
            profileAboutMeStepsObj.CancelEarnTargetEdit();
            profileAssertionsObj.AssertEarnTargetEditWasCancelled();
        }

        [TearDown]
        public void CloseTestRun()
        {
            reportWriter.RecordTestRunData(TestContext.CurrentContext);
            driver.Quit();
        }
    }
}
