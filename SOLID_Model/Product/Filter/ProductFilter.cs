using SOLID_Model.Product.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Model.Product.Filter
{
    //
    public class ProductFilter
    {
        public IEnumerable<ProductModel> By(IList<ProductModel> products, ProductFilterSpecification filterSpecification) {
            return filterSpecification.Filter(products);
        }
    }
}
