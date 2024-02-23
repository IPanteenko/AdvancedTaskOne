using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.TestData.Enums
{
    internal static class EarnTarget
    {
        public static SelectItem LessThan = new SelectItem { Value = 0, DisplayText = "Less than $500 per month" };
        public static SelectItem Between = new SelectItem { Value = 1, DisplayText = "Between $500 and $1000 per month" };
        public static SelectItem PartTime = new SelectItem { Value = 2, DisplayText = "More than $1000 per month" };

    }
}
