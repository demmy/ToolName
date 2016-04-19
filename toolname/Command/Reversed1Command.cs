using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolName.Contract;

namespace ToolName.Command
{
    public class Reversed1Command : BaseCommand
    {
        public Reversed1Command(IFileService service):base(service) { }

        public override IEnumerable<string> Execute(string start)
        {
            return _service.GetFiles(start, ".*").Select(f => string.Join(@"\", f.Split('\\').Reverse()));
        }
    }
}
