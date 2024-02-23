using AdvancedTask1.Model.SignIn;
using AdvancedTask1.Pages.SignInPage.Component;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Pages.SignInPage
{
    public class SignInPage
    {
        private readonly IWebDriver driver;
        private readonly SignInComponent signInComponent;
        private const string userEmail1 = "panteenko@gmail.com";
        private const string password1 = "Z5t3RKM\"4K2yj~c";
        private const string userEmail2 = "moseko4211@roborena.com";
        private const string password2 = "123456";
        

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
            signInComponent = new SignInComponent(driver);
        }

       

        public void SignTheUserMainIn()
        {
            signInComponent.SignInButton.Click();
            signInComponent.EmailTextBox.SendKeys(userEmail1);
            signInComponent.PasswordTextBox.SendKeys(password1);
            signInComponent.LoginButton.Click();
        }

        public void SignTheHelperIn()
        {
            signInComponent.SignInButton.Click();
            signInComponent.EmailTextBox.SendKeys(userEmail2);
            signInComponent.PasswordTextBox.SendKeys(password2);
            signInComponent.LoginButton.Click();
        }

    }
}
