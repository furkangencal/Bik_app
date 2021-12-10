using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bik_app.Models
{
    public class ProductSubcategory
    {
        public int ProductSubcategoryID { get; set; }
        public int ProductCategoryID{ get; set; }
        public string Name{ get; set; }
        public Guid rowguid{ get; set; }
        public DateTime ModifiedDate{ get; set; }
    }
}
