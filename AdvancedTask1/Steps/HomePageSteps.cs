using AdvancedTask1.Pages.HomePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Steps
{
    public class HomePageSteps
    {
      
        public readonly HomePage homePageObj;

        public HomePageSteps(IWebDriver driver)
        {
            homePageObj = new HomePage(driver);
        }

        public void SwitchToSkillsTab()
        {
            homePageObj.ClickSkillTabButton();
        }

        public void OpenShareSkillPage()
        { 
            homePageObj.ClickShareSkillButton();
        }

        public void SearchSkills()
        {
            homePageObj.ClickSearchButton();
        }

       
       
    }
}
