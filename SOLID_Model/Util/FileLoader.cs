using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Model.Util
{
    /// <summary>
    /// ReadFile
    /// </summary>
    public class FileLoader : IFileLoader
    {
        public Stream Load(string fileName)
        {
            return new FileStream(fileName, FileMode.Open);
        }
    }
}
