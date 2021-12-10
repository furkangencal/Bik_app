﻿// <auto-generated />
using System;
using Bik_app.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bik_app.Migrations
{
    [DbContext(typeof(Bik_appContext))]
    partial class Bik_appContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bik_app.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DaysToManufacture")
                        .HasColumnType("int");

                    b.Property<DateTime>("DiscontinuedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("FinishedGoodsFlag")
                        .HasColumnType("bit");

                    b.Property<decimal>("ListPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("MakeFlag")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductModelID")
                        .HasColumnType("int");

                    b.Property<string>("ProductNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductSubcategoryID")
                        .HasColumnType("int");

                    b.Property<short>("ReorderPoint")
                        .HasColumnType("smallint");

                    b.Property<short>("SafetyStockLevel")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("SellEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SellStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeUnitMeasureCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("StandardCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Style")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("WeightUnitMeasureCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("rowguid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Bik_app.Models.ProductCategory", b =>
                {
                    b.Property<int>("ProductCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("rowguid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductCategoryID");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("Bik_app.Models.ProductSubcategory", b =>
                {
                    b.Property<int>("ProductSubcategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductCategoryID")
                        .HasColumnType("int");

                    b.Property<Guid>("rowguid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductSubcategoryID");

                    b.ToTable("ProductSubcategories");
                });
#pragma warning restore 612, 618
        }
    }
}
