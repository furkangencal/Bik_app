using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bik_app.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }

        public int ProductSubcategoryID { get; set; }
    }
}
