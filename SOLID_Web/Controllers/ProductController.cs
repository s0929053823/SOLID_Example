using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SOLID_Web.Controllers
{
    public class ProductController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }

    }
}