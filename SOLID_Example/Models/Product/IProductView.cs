using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Example.Models.Product
{

    public interface IProductView
    {
        void Initialize(ProductPresenter presenter);
        string GetFileName();
        void ShowProducts(IEnumerable<ProductModel> products);
        void SetFileName(string fileName);
    }
}
