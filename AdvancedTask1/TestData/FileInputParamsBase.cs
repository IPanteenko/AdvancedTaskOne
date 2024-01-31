using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedTask1.Utilities;

namespace AdvancedTask1.TestData
{
    public class FileInputParamsBase<TTestCaseParams> : IEnumerable
    {
        protected virtual string DataFilesSubFolder => "TestData";

        protected virtual string FileName => "";

        private string GetFilePath()
        {
            var directoryName = FileSystem.GetRootDirectory();

            return Path.Combine(directoryName, DataFilesSubFolder, $"{FileName}.json");
        }

        public IEnumerator GetEnumerator()
        {
            var jsonData = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(GetFilePath()));
            var genericItems = jsonData["testData"].ToObject<TTestCaseParams>();

            yield return new object[] { genericItems };
        }
    }
}
