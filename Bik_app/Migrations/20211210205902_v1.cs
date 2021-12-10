using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bik_app.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.ProductCategoryID);
                    table.UniqueConstraint("AK_ProductCategory_Name", x => x.Name);
                    table.UniqueConstraint("AK_ProductCategory_rowguid", x => x.rowguid);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MakeFlag = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    FinishedGoodsFlag = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SafetyStockLevel = table.Column<short>(type: "smallint", nullable: false),
                    ReorderPoint = table.Column<short>(type: "smallint", nullable: false),
                    StandardCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ListPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeUnitMeasureCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeightUnitMeasureCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DaysToManufacture = table.Column<int>(type: "int", nullable: false),
                    ProductLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSubcategoryID = table.Column<int>(type: "int", nullable: false),
                    ProductModelID = table.Column<int>(type: "int", nullable: false),
                    SellStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SellEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscontinuedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.UniqueConstraint("AK_Product_Name", x => x.Name);
                    table.UniqueConstraint("AK_Product_ProductNumber", x => x.ProductNumber);
                    table.UniqueConstraint("AK_Product_rowguid", x => x.rowguid);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubcategories",
                columns: table => new
                {
                    ProductSubcategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubcategories", x => x.ProductSubcategoryID);
                    table.UniqueConstraint("AK_ProductSubcategory_Name", x => x.Name);
                    table.UniqueConstraint("AK_ProductSubcategory_rowguid", x => x.rowguid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductSubcategories");
        }
    }
}
