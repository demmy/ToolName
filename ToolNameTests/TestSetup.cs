using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolName.Contract;

namespace ToolNameTests
{
    public static class TestSetup
    {
        public static List<string> FilePath
        {
            get
            {
                return new List<string>
                    {
                        @"\SomeFolder\InnerFolder\deeper\someFile.cpp"
                    };
            }
        }

        public static IFileService GetService()
        {
            return Mock.Of<IFileService>(s => s.GetFiles(
                It.IsAny<string>(), It.IsAny<string>()) == FilePath);
        }
    }
}
