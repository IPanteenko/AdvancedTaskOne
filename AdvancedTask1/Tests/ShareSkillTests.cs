using AdvancedTask1.Assertions;
using AdvancedTask1.Model.ShareSkill;
using AdvancedTask1.Reports;
using AdvancedTask1.Steps;
using AdvancedTask1.TestData.InputSources;
using AdvancedTask1.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Tests
{
    [TestFixture]
    public class ShareSkillTests: CommonDriver
    {
        private SignInSteps signinStepsObj;
        private ShareSkillSteps shareSkillStepsObj;
        private HomePageSteps homePageStepsObj;
        private ShareSkillAssertions shareSkillAssertionsObj;
        private ReportWriter reportWriterObj;

        public void CreatePageObjects()
        {
            signinStepsObj = new SignInSteps(driver);
            shareSkillStepsObj = new ShareSkillSteps(driver);
            homePageStepsObj = new HomePageSteps(driver);
            shareSkillAssertionsObj = new ShareSkillAssertions(driver);
        }

        public void CreateReporter()
        {
            reportWriterObj = new ReportWriter(nameof(ShareSkillTests));
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
            reportWriterObj.InitialiseTestRun(TestContext.CurrentContext.Test.Name);
            reportWriterObj.AddScreenshotTaker(driver);
            signinStepsObj.PortalSignIn();
            homePageStepsObj.OpenShareSkillPage();
        }

        [TestCaseSource(typeof(ShareSkillValidInputSource<ShareSkill>))]
        public void ShareValidSkill(ShareSkill validSkill)
        {
            // Set unique title
            validSkill.Title += DateTime.Now.Ticks;
            shareSkillStepsObj.ShareValidSkill(validSkill);
            shareSkillAssertionsObj.AssertSharedSkillMatchesActualSkill(validSkill);
        }

        [TestCaseSource(typeof(ShareSkillValidInputSource<ShareSkill>))]
        public void TryShareSkillWithoutTitle(ShareSkill skill)
        {
            
            shareSkillStepsObj.ShareSkillWithoutTitle(skill);
            shareSkillAssertionsObj.AssertErrorMessageIsDisplayed();
        }

        [TestCaseSource(typeof(ShareSkillValidInputSource<ShareSkill>))]
        public void TryShareSkillWithoutDescription(ShareSkill skill)
        {

            shareSkillStepsObj.ShareSkillWithoutDescription(skill);
            shareSkillAssertionsObj.AssertErrorMessageIsDisplayed();
        }

        [TestCaseSource(typeof(ShareSkillValidInputSource<ShareSkill>))]
        public void TryShareSkillWithoutCategory(ShareSkill skill)
        {

            shareSkillStepsObj.ShareSkillWithoutCategory(skill);
            shareSkillAssertionsObj.AssertErrorMessageIsDisplayed();
        }

        [TestCaseSource(typeof(ShareSkillValidInputSource<ShareSkill>))]
        public void TryShareSkillWithoutSubCategory(ShareSkill skill)
        {

            shareSkillStepsObj.ShareSkillWithoutSubCategory(skill);
            shareSkillAssertionsObj.AssertErrorMessageIsDisplayed();
        }

        [TestCaseSource(typeof(ShareSkillValidInputSource<ShareSkill>))]
        public void TryShareSkillWithoutTag(ShareSkill skill)
        {

            shareSkillStepsObj.ShareSkillWithoutTag(skill);
            shareSkillAssertionsObj.AssertErrorMessageIsDisplayed();
        }

        [TestCaseSource(typeof(ShareSkillWithMoreThanMaxCharactersIS<ShareSkill>))]
        public void TryShareSkillWithMoreThanMaxAmountOfCharachtersInTitle(ShareSkill skill)
        {
            shareSkillStepsObj.ShareValidSkill(skill);
            shareSkillAssertionsObj.AssertAmountOfCharactersInTitle();
            
        }


        [TestCaseSource(typeof(ShareSkillWithMoreThanMaxCharactersIS<ShareSkill>))]
        public void TryShareSkillWithMoreThanMaxAmountOfCharactersInDescription(ShareSkill skill)
        {
            shareSkillStepsObj.ShareValidSkill(skill);
            shareSkillAssertionsObj.AssertAmountOfCharactersInDescription();
        }

        [TestCaseSource(typeof(ShareSkilllWithSpecialCharactersIS<ShareSkillSpecialCharacters>))]
        public void TryShareSkillWithSpecialCharactersInTitle(ShareSkillSpecialCharacters skill)
        {
            shareSkillStepsObj.ShareValidSkill(skill.InTitle);
            shareSkillAssertionsObj.AssertErrorMessageIsDisplayed();
            shareSkillAssertionsObj.AssertSpecialCharactersNotificationInTitlePresent();
        }

        [TestCaseSource(typeof(ShareSkilllWithSpecialCharactersIS<ShareSkillSpecialCharacters>))]
        public void TryShareSkillWithSpecialCharactersInDescription(ShareSkillSpecialCharacters skill)
        {
            shareSkillStepsObj.ShareValidSkill(skill.InDescription);
            shareSkillAssertionsObj.AssertErrorMessageIsDisplayed();
            shareSkillAssertionsObj.AssertSpecialCharactersNotificationInDescriptionPresent();
        }

        [TestCaseSource(typeof(ShareSkillWithInvalidDateIS<ShareSkill>))]
        public void TryShareSkilWithInvalidDate(ShareSkill skill)
        {

            shareSkillStepsObj.ShareValidSkill(skill);
            shareSkillAssertionsObj.AssertErrorMessageIsDisplayed();
            shareSkillAssertionsObj.AssertStartEndDateNotificationPresent();
        }

        [TearDown]
        public void CloseTestRun()
        {
            reportWriterObj.RecordTestRunData(TestContext.CurrentContext);
            driver.Quit();
        }
    }

}
