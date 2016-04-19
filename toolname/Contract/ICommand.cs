using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolName.Contract
{
    public interface ICommand
    {
        IEnumerable<string> Execute(string start);
    }
}
