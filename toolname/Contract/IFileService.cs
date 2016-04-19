using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolName.Contract
{
    public interface IFileService
    {
        IEnumerable<string> GetFiles(string start, string extension);
    }
}
