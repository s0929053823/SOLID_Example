using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SOLID_Model.Product
{
    public interface IProductMapper
    {
        ProductModel Map(XmlReader reader);
    }
}
