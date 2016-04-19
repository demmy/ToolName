using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolName.Contract;

namespace ToolName
{
    public class FileService : IFileService
    {
        public IEnumerable<string> GetFiles(string start, string extension)
        {
            return Directory.GetFiles(start, "*" + extension, SearchOption.AllDirectories)
                .Select(d => d.Substring(start.Length));
        }
    }
}
