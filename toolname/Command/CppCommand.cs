using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolName.Contract;

namespace ToolName.Command
{
    public class CppCommand : BaseCommand
    {
        public CppCommand(IFileService service):base(service) { }

        public override IEnumerable<string> Execute(string start)
        {
            var files = _service.GetFiles(start, ".cpp");
            return files.Select(s => s + " /");
        }
    }
}
