using AdvancedTask1.Assertions;
using AdvancedTask1.Model.Languages;
using AdvancedTask1.Model.SignIn;
using AdvancedTask1.Pages.SignInPage;
using AdvancedTask1.Reports;
using AdvancedTask1.Steps;
using AdvancedTask1.TestData.InputSources;
using AdvancedTask1.Utilities;
using NUnit.Framework;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Tests
{
    [TestFixture]
    internal class LanguagesTests : CommonDriver
    {
        private LanguagesTabSteps languagesTabStepsObj;
        private SignInSteps signInStepsObj;
        private LanguagesAssertions languagesAssertionsObj;
        private ReportWriter reportWriter;

        public void CreatePageObjects()
        {
            languagesTabStepsObj = new LanguagesTabSteps(driver);
            signInStepsObj = new SignInSteps(driver);
            languagesAssertionsObj = new LanguagesAssertions(driver);
        }

        public void CreateReporter()
        {
            reportWriter = new ReportWriter(nameof(LanguagesTests));
        }

        [OneTimeSetUp]
        public void OneTimeSetup()
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
            languagesTabStepsObj.LanguagesDataReset();
        }


        [TestCaseSource(typeof(AddValidLanguageInputSource<Languages>))]
        public void CreateValidLanguageRecord(Languages language)
        {
            languagesTabStepsObj.AddNewLanguage(language);
            languagesAssertionsObj.AssertActualLanguageMatchesCreated(language);
        }

        [TestCaseSource(typeof(AddValidLanguageInputSource<Languages>))]
        public void CreateLanguageWithoutName(Languages language)
        {
            languagesTabStepsObj.AddLanguageWithoutName(language);
            languagesAssertionsObj.AssertAdditionWithEmptyFieldUnsuccessful();
        }

        [TestCaseSource(typeof(AddValidLanguageInputSource<Languages>))]
        public void CreateLanguageWithoutLevel(Languages language)
        {
            languagesTabStepsObj.AddLanguageWithoutLevel(language);
            languagesAssertionsObj.AssertAdditionWithEmptyFieldUnsuccessful();
        }

        [TestCaseSource(typeof(EditValidLanguageInputSource<EditLanguage>))]
        public void EditValidLanguageRecord(EditLanguage language)
        {
            languagesTabStepsObj.AddNewLanguage(language.Original);
            languagesTabStepsObj.EditLanguage(language.Edited);
            languagesAssertionsObj.AssertActualLanguageMatchesCreated(language.Edited);
        }

        [TestCaseSource(typeof(AddValidLanguageInputSource<Languages>))]
        public void DeleteLanguageRecord(Languages language)
        {
            languagesTabStepsObj.AddNewLanguage(language);
            languagesTabStepsObj.DeleteLanguageRecord();
            languagesAssertionsObj.AssertThatLanguageWasDeleted();
        }

        [TestCaseSource(typeof(AddValidLanguageInputSource<Languages>))]
        public void CancelLanguageRecordAddition(Languages language)
        {
            languagesTabStepsObj.CancelLanguageAddition(language);
            languagesAssertionsObj.AssertThatLanguageAdditionWasCancelled(); ;
        }

        [TestCaseSource(typeof(AddValidLanguageInputSource<Languages>))]

        public void CencelLanguageRecordEdit(Languages language)
        {
            languagesTabStepsObj.AddNewLanguage(language);
            languagesTabStepsObj.CancelLanguageEdit();
            languagesAssertionsObj.AssertThatUpdateWasCancelled();
        }

        [Test]
        public void TryToDeleteNonexistantRecord()
        {
            languagesAssertionsObj.AssertThatDeleteButtonIsNotPresent();
        }

        [Test]
        public void TryToEditNonExistantRecord()    
        {
            languagesAssertionsObj.AssertThatEditbuttonIsNotPresent();
        }

        [TearDown]
        public void CloseTestRun()
        {
            reportWriter.RecordTestRunData(TestContext.CurrentContext);
            driver.Quit();
        }
    }
}
