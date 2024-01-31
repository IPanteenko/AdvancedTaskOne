using AdvancedTask1.Model.SignIn;
using AdvancedTask1.Pages.SignInPage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Steps
{
    internal class SignInSteps
    {
        public readonly IWebDriver driver;
        public readonly SignInPage signInPageObj;

        public SignInSteps(IWebDriver driver)
        {
            this.driver = driver;
            signInPageObj = new SignInPage(driver);
        }

        public void PortalSignIn()
        {
            signInPageObj.SignTheUserMainIn();
        }

        public void SignInSetUpHelper()
        {
            signInPageObj.SignTheHelperIn();
        }   
    }
}
