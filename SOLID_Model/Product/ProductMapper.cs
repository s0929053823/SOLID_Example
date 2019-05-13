using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SOLID_Model.Product
{
    public class ProductMapper : IProductMapper
    {
        public ProductModel Map(XmlReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException("XML reader used when mapping cannot be null.");
            if (reader.Name != "product")
                throw new InvalidOperationException("XML reader is not on a product fragment.");
            var product = new ProductModel();
            product.Id = int.Parse(reader.GetAttribute("id"));
            product.Name = reader.GetAttribute("name");
            product.UnitPrice = decimal.Parse(reader.GetAttribute("unitPrice"));
            product.Discontinued = bool.Parse(reader.GetAttribute("discontinued"));
            return product;
        }
    }
}
