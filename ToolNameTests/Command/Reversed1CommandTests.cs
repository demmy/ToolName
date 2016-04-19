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
    public class Reversed1CommandTests
    {
        [Test()]
        public void Reversed1CommandExecuteTest()
        {
            var filePath = TestSetup.FilePath;
            IFileService service = TestSetup.GetService();

            var command = new Reversed1Command(service);
            var result = command.Execute("D:");

            var expectedResult = new List<string> { @"someFile.cpp\deeper\InnerFolder\SomeFolder\" };
            

            Assert.AreEqual(expectedResult, result);
        }
    }
}