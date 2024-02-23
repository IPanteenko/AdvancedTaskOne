using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Pages.SignInPage.Component
{
    public class SignInComponent
    {
        private readonly IWebDriver driver;
        
       public SignInComponent(IWebDriver driver)
        {
            this.driver = driver;
        }

       public IWebElement SignInButton => driver.FindElement(By.XPath("//a[contains(text(),'Sign In')]"));
       public IWebElement EmailTextBox => driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/input[1]"));
       public IWebElement PasswordTextBox => driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/input[1]"));
       public IWebElement LoginButton => driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));

        
    }
}
    

