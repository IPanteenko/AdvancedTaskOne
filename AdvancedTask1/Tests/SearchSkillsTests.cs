using AdvancedTask1.Assertions;
using AdvancedTask1.Model.ShareSkill;
using AdvancedTask1.Pages.SearchPage.Component;
using AdvancedTask1.Reports;
using AdvancedTask1.Steps;
using AdvancedTask1.TestData.InputSources;
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
    public class SearchSkillsTests : CommonDriver
    {
        private SignInSteps signInStepsObj;
        private HomePageSteps homePageStepsObj;
        private SearchSkillSteps searchSkillStepsObj;
        private ShareSkillSteps shareSkillStepsObj;
        private SearchAssertions searchAssertionsObj;
        private ReportWriter reportWriterObj;

        public void CreatePageObjects()
        {
            signInStepsObj = new SignInSteps(driver);
            homePageStepsObj = new HomePageSteps(driver);
            searchSkillStepsObj = new SearchSkillSteps(driver);
            shareSkillStepsObj = new ShareSkillSteps(driver);
            searchAssertionsObj = new SearchAssertions(driver);
        }

        public void CreateReporter()
        {
            reportWriterObj = new ReportWriter(nameof(SearchSkillsTests));
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
            signInStepsObj.PortalSignIn();
            homePageStepsObj.OpenShareSkillPage();

        }

        [TestCaseSource(typeof(ShareSkillValidInputSource<ShareSkill>))]
        public void FindSkillInRightCategory(ShareSkill skill)
        {
            shareSkillStepsObj.ShareValidSkill(skill);
            homePageStepsObj.SearchSkills();
            searchSkillStepsObj.SearchSkillInMarketingCategory(skill);
            searchAssertionsObj.AssertListingsWereFound();
        }

        [TestCaseSource(typeof(ShareSkillValidInputSource<ShareSkill>))]
        public void TryToFindSkillInWrongCategory(ShareSkill skill)
        {
            shareSkillStepsObj.ShareValidSkill(skill);
            homePageStepsObj.SearchSkills();
            searchSkillStepsObj.SearchSkillInWrongCategory(skill);
            searchAssertionsObj.AssertListingIsNotFoundInWrongCategory();
            ;
        }

        [TestCaseSource(typeof(ShareSkillValidInputSource<ShareSkill>))]
        public void FindOnlineListings(ShareSkill skill)
        {
            shareSkillStepsObj.ShareValidSkill(skill);
            homePageStepsObj.SearchSkills();
            searchSkillStepsObj.FindOnlineListings(skill);
            searchAssertionsObj.AssertListingsWereFound();
        }

        [TestCaseSource(typeof(ShareSkillValidInputSource<ShareSkill>))]
        public void TryToFindSkillInRightSubcategory(ShareSkill skill)
        {
            shareSkillStepsObj.ShareValidSkill(skill);
            homePageStepsObj.SearchSkills();
            searchSkillStepsObj.SearchSkillInRightSubcategory(skill);
            searchAssertionsObj.AssertListingsWereFound();
        }

        [TestCaseSource(typeof(ShareSkillValidInputSource<ShareSkill>))]
        public void TryToFindSkillInWrongSubcategory(ShareSkill skill)
        {
            shareSkillStepsObj.ShareValidSkill(skill);
            homePageStepsObj.SearchSkills();
            searchSkillStepsObj.SearchSkillInWrongSubcategory(skill);
            searchAssertionsObj.AssertListingIsNotFoundInWrongCategory();
        }

        [TearDown]
        public void CloseTestRun()
        {
            reportWriterObj.RecordTestRunData(TestContext.CurrentContext);
            driver.Quit();
        }
    }
}
