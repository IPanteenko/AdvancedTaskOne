using AdvancedTask1.Assertions;
using AdvancedTask1.Pages.Notification;
using AdvancedTask1.Reports;
using AdvancedTask1.Steps;
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

    internal class NotificationTests : CommonDriver
    {
        private NotificationSteps notificationStepsObj;
        private SignInSteps signInStepsObj;
        private NotificationAssertions notificationAssertions;
        private ReportWriter reportWriter;

        public void CreatePageObjects()
        {
            signInStepsObj = new SignInSteps(driver);
            notificationStepsObj =  new NotificationSteps(driver);
            notificationAssertions = new NotificationAssertions(driver);    
        }

        public void CreateReporter()
        {
            reportWriter = new ReportWriter(nameof(NotificationTests));
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
            notificationStepsObj.OpenNotifications();

        }

        [Test]
        public void LoadMoreNotificatios()
        {
            notificationStepsObj.LoadMoreNotifications();
            notificationAssertions.AssertMoreNotificationShowm();
        }

        [Test]
        public void ShowLessNotificatios()
        {
            notificationStepsObj.LoadMoreNotifications();
            notificationStepsObj.ShowLessNotifications();
            notificationAssertions.AssertLessNotificationsShown();
        }

        [TearDown]
        public void CloseTestRun()
        {
            reportWriter.RecordTestRunData(TestContext.CurrentContext);
            driver.Quit();
        }
    }
}
