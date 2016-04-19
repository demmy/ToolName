using NUnit.Framework;
using ToolName.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolName.Contract;
using Moq;
using ToolNameTests;

namespace ToolName.Command.Tests
{
    [TestFixture()]
    public class AllCommandTests
    {
        [Test()]
        public void AllCommandExecuteTest()
        {
            var filePath = TestSetup.FilePath;
            IFileService service = TestSetup.GetService();


            var command = new AllCommand(service);
            var result = command.Execute("D:");

            Assert.AreEqual(filePath, result);
        }
    }
}