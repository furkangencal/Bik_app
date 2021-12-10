using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bik_app.Models
{
    public class Product
    {
        public int ProductID;
        public string Name;
        public string ProductNumber;
        public Boolean MakeFlag;
        public Boolean FinishedGoodsFlag;
        public string Color;
        public Int16 SafetyStockLevel;
        public Int16 ReorderPoint;
        public decimal StandardCost;
        public decimal ListPrice;
        public string Size;
        public string SizeUnitMeasureCode;
        public string WeightUnitMeasureCode;
        public decimal Weight;
        public int DaysToManufacture;
        public string ProductLine;
        public string Class;
        public string Style;
        public int ProductSubcategoryID;
        public int ProductModelID;
        public DateTime SellStartDate;
        public DateTime SellEndDate;
        public DateTime DiscontinuedDate;
        public Guid rowguid;
        public DateTime ModifiedDate;

    }
}
