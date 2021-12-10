using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bik_app.Models
{
    public class ProductSubcategory
    {
        public int ProductSubcategoryID;
        public int ProductCategoryID;
        public string Name;
        public Guid rowguid;
        public DateTime ModifiedDate;
    }
}
