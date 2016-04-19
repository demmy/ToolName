using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolName.Contract;

namespace ToolName.Command
{
    public abstract class BaseCommand : ICommand
    {
        public abstract IEnumerable<string> Execute(string start);

        protected IFileService _service;
        public BaseCommand(IFileService service)
        {
            _service = service;
        }
    }
}
