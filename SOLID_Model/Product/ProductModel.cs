﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Model.Product
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Discontinued { get; set; }

        public override string ToString() => string.Format("Id:{0},Name:{1},UnitPrice:{2},Discontinued:{3}", Id, Name, UnitPrice, Discontinued);
       
    }


}
