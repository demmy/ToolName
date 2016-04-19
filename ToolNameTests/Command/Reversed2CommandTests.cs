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
    public class Reversed2CommandTests
    {
        [Test()]
        public void Reversed2CommandExecuteTest()
        {
            var filePath = TestSetup.FilePath;
            IFileService service = TestSetup.GetService();

            var command = new Reversed2Command(service);
            var result = command.Execute("D:");

            var expectedResult = new List<string> { @"ppc.eliFemos\repeed\redloFrennI\redloFemoS\" };


            Assert.AreEqual(expectedResult, result);
        }
    }
}