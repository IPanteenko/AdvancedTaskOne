using AventStack.ExtentReports.Gherkin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.TestData.Enums
{
    internal static class Hours
    {
        public static SelectItem LessThan = new SelectItem { Value = 0, DisplayText = "Less than 30hours a week" };
        public static SelectItem MoreThan = new SelectItem { Value = 1, DisplayText = "More than 30hours a week" };
        public static SelectItem AsNeeded = new SelectItem { Value = 2, DisplayText = "As needed" };  
    }
}
