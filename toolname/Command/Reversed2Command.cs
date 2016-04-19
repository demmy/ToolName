using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolName.Contract;

namespace ToolName.Command
{
    public class Reversed2Command : BaseCommand
    {
        public Reversed2Command(IFileService service):base(service) { }

        public override IEnumerable<string> Execute(string start)
        {
            return _service.GetFiles(start, ".*").Select(f => new string(f.Reverse().ToArray()));
        }
    }
}
