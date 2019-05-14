using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Model.Product
{
    public class ProductPresenter
    {
        private readonly IProductRepository repository;

        private string fileName;

        public ProductPresenter(string fileName)
        {
            repository = new ProductRepository();
            this.fileName = fileName;
        }



        public string GetProductsDetails()
        {
            var products = repository.GetByFileName(this.fileName);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var product in products)
                stringBuilder.Append(product.ToString()+"\r\n");

            return stringBuilder.ToString();
        }
    }
}
