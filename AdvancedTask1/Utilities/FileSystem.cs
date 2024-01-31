using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask1.Utilities
{
    internal class FileSystem
    {
        public static string GetRootDirectory()
        {
            var directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (directoryName == null)
                throw new Exception("Couldn't get assembly directory");

            return directoryName;
        }

        public static void CreateDirectory(string directoryName)
        {
            Directory.CreateDirectory($"{GetRootDirectory()}\\{directoryName}");
        }
    }
}
