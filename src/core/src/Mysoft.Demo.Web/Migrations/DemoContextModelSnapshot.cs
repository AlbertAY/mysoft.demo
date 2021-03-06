﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mysoft.Demo.Web.Models.DBConfig;

namespace Mysoft.Demo.Web.Migrations
{
    [DbContext(typeof(DemoContext))]
    partial class DemoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mysoft.Demo.Web.Models.Product", b =>
                {
                    b.Property<Guid>("ProductGUID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("CurrentPrice");

                    b.Property<string>("Description");

                    b.Property<string>("Pictures")
                        .HasMaxLength(800);

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<Guid?>("ProductTypeGUID");

                    b.Property<string>("ProviderName")
                        .HasMaxLength(80);

                    b.Property<string>("Remark");

                    b.Property<string>("Unit")
                        .HasMaxLength(10);

                    b.HasKey("ProductGUID");

                    b.HasIndex("ProductTypeGUID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Mysoft.Demo.Web.Models.ProductType", b =>
                {
                    b.Property<Guid>("ProductTypeGUID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ProductTypeGUID");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("Mysoft.Demo.Web.Models.Product", b =>
                {
                    b.HasOne("Mysoft.Demo.Web.Models.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeGUID");
                });
#pragma warning restore 612, 618
        }
    }
}
