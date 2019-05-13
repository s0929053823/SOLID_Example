using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Example.Models.Product
{
    public interface IProductRepository
    {
        IEnumerable<ProductModel> GetByFileName(string fileName);
    }
}
