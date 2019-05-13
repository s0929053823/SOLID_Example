using System;
using System.Collections.Generic;
using System.Text;
using Gtk;

namespace SOLID_Example.Models.Product
{
    public class ProductPresenter
    {

        private readonly FileChooserDialog openFileDialog;
        private readonly IProductRepository repository;
        private readonly IProductView view;


        public ProductPresenter()
        {
            //view = new Program();
            //view.Initialize();
            //repository = new ProductRepository();
            //openFileDialog = new FileChooserDialog();
        }

        public void BrowseForFileName()
        { 

        }

        public IEnumerable<ProductModel> GetProducts()
        {
        return new List<ProductModel>();
        }
    }
}
