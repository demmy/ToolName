using NUnit.Framework;
using ToolName.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolNameTests;
using ToolName.Contract;

namespace ToolName.Command.Tests
{
    [TestFixture()]
    public class CppCommandTests
    {
        [Test()]
        public void CppCommandExecuteTest()
        {
            var filePath = TestSetup.FilePath;
            IFileService service = TestSetup.GetService();

            var command = new CppCommand(service);
            var result = command.Execute("D:");

            var expectedResult = new List<string> { @"\SomeFolder\InnerFolder\deeper\someFile.cpp /" };

            Assert.AreEqual(expectedResult, result);

        }
    }
}