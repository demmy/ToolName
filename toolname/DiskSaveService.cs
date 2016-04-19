using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolName.Contract;

namespace ToolName
{
    public class DiskSaveService : ISaveService
    {
        public void SaveResult(IEnumerable<string> results, string output)
        {
            System.IO.File.WriteAllLines(output,results);
        }
    }
}
