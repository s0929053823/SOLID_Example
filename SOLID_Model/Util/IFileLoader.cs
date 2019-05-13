using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace SOLID_Model.Util
{
    /// <summary>
    /// Interface of FileLoader
    /// </summary>
    public interface IFileLoader
    {
        Stream Load(string fileName);
    }
}
