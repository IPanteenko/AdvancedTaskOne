using AdvancedTask1.Assertions;
using AdvancedTask1.Model.Skills;
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
    internal class SkillsTests : CommonDriver
    {
        private SkillsTabSteps skillsTabStepsObj;
        private SignInSteps signInStepsObj;
        private SkillsAssertions skillsAssertionsObj;
        private HomePageSteps homePageStepsObj;
        private ReportWriter reportWriter;

        public void CreatePageObjects()
        {
            skillsTabStepsObj = new SkillsTabSteps(driver);
            signInStepsObj = new SignInSteps(driver);
            skillsAssertionsObj = new SkillsAssertions(driver);
            homePageStepsObj = new HomePageSteps(driver);
        }

        public void CreateReporter()
        {
            reportWriter = new ReportWriter(nameof(SkillsTests));
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            CreateReporter();
        }

        [SetUp]
        public void SetUp()
        {
            OpenPortal();
            CreatePageObjects();
            reportWriter.InitialiseTestRun(TestContext.CurrentContext.Test.Name);
            reportWriter.AddScreenshotTaker(driver);
            signInStepsObj.PortalSignIn();
            homePageStepsObj.SwitchToSkillsTab();
            skillsTabStepsObj.SkillsDataReset();
        }

        [TestCaseSource(typeof(AddValidSkillInputSource<Skills>))]
        public void CreateValidSkillRecord(Skills skills)
        {
            skillsTabStepsObj.AddNewSkill(skills);
            skillsAssertionsObj.AssertThatActuaAndCreatedRecordsMatch(skills);
        }

        [TestCaseSource(typeof(AddValidSkillInputSource<Skills>))]
        public void CreateSkillRecordWithoutName(Skills skills)
        {
            skillsTabStepsObj.AddSkillWithoutName(skills);
            skillsAssertionsObj.AssertAdditionWasUnsuccessfull();
        }

        [TestCaseSource(typeof(AddValidSkillInputSource<Skills>))]

        public void CreateNewSkillWithoutLevel(Skills skills)
        {
            skillsTabStepsObj.AddSkillWithoutLevel(skills);
            skillsAssertionsObj.AssertAdditionWasUnsuccessfull();
        }

        [TestCaseSource(typeof(EditSkillInputSource<EditSkill>))]
        public void EditValidSkill(EditSkill skill)
        {
            skillsTabStepsObj.AddNewSkill(skill.Original);
            skillsTabStepsObj.EditSkill(skill.Edited);
            skillsAssertionsObj.AssertEditWasSuccessful(skill.Edited);
        }

        [TestCaseSource(typeof(AddValidSkillInputSource<Skills>))]
        public void DeleteSkillRecord(Skills skills)
        {
            skillsTabStepsObj.AddNewSkill(skills);
            skillsTabStepsObj.DeleteSkill();
            skillsAssertionsObj.AssertThatSkillRecordWasDeleted();
        }

        [TestCaseSource(typeof(AddValidSkillInputSource<Skills>))]
        public void CancelSkillAddition(Skills skills)
        {
            skillsTabStepsObj.CancelNewSkillAddition(skills);
            skillsAssertionsObj.AssertThatSkillAdditionWasCancelled();
        }

        [TestCaseSource(typeof(EditSkillInputSource<EditSkill>))]
        public void CancelSkillEdit(EditSkill skill)
        {
            skillsTabStepsObj.AddNewSkill(skill.Original);
            skillsTabStepsObj.CancelSkillEdit(skill.Edited);
            skillsAssertionsObj.AssertThatSkillEditWasCancelled();
        }

        [Test]
        public void TryToDeleteNonExistantRecord()
        {
            skillsAssertionsObj.AssertThatDeleteButtonIsNotPresent();
        }

        [Test]
        public void TryToEditNonExistantRecord()
        {
            skillsAssertionsObj.AssertThatEditButtonIsNotPresent();
        }
           
        
        [TearDown]
        public void CloseTestRun()
            {
                reportWriter.RecordTestRunData(TestContext.CurrentContext);
                driver.Quit();
            }
        }
    }

