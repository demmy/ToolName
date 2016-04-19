using System;
using System.Collections.Generic;
using ToolName.Contract;

namespace ToolName.Command
{
    public class AllCommand : BaseCommand
    {
        public AllCommand(IFileService service):base(service) { }

        public override IEnumerable<string> Execute(string start)
        {
            return _service.GetFiles(start, ".*");
        }
    }
}