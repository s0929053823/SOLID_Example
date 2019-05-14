using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Model.Product.Filter
{
    public abstract class ProductFilterSpecification
    {
        public IEnumerable<ProductModel> Filter(IList<ProductModel> products) {
            return ApplyFilter(products);
        }

        protected abstract IEnumerable<ProductModel> ApplyFilter(IList<ProductModel> products);
    }

    public class ColorFilterSpecification : ProductFilterSpecification
    {
        private readonly ProductColor productColor;

        public ColorFilterSpecification(ProductColor productColor)
        {
            this.productColor = productColor;
        }

        protected override IEnumerable<ProductModel> ApplyFilter(IList<ProductModel> products)
        {
            foreach (var product in products)
            {
                if (product.Color == productColor)
                    yield return product;
            }
        }
    }

}
