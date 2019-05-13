using SOLID_Model.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SOLID_Model.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly IFileLoader loader;
        private readonly IProductMapper mapper;

        public ProductRepository() {
            loader = new FileLoader();
            mapper = new ProductMapper();
        }

        public IEnumerable<ProductModel> GetByFileName(string fileName)
        {
            var products = new List<ProductModel>();
            using (Stream input = loader.Load(fileName))
            {
                var reader = XmlReader.Create(input);
                while (reader.Read())
                {
                    if (reader.Name != "product")
                        continue;
                    var product = mapper.Map(reader);
                    products.Add(product);
                }
            }
            return products;
        }
    }
}
