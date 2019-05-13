using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using SOLID_Model.Product;

namespace SOLID_Web.Controllers
{
    public class ProductController : Controller
    {

        public string Index()
        {
            string FILE_NAME = Path.Combine( Directory.GetCurrentDirectory(),"wwwroot", "AppData","testfile.xml");

            var presenter = new ProductPresenter(FILE_NAME);

            return presenter.GetProductsDetails();
        }

    }
}