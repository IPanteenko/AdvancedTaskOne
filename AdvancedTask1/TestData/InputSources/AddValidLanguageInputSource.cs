using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.TestData.InputSources
{
    internal class AddValidLanguageInputSource<T> : FileInputParamsBase<T>
    {
        protected override string FileName => "AddValidLanguage";
    }

}
    
