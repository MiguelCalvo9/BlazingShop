﻿// <auto-generated />
using BlazingShop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazingShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220927023821_ProductSeeding")]
    partial class ProductSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazingShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "La cerveza ​ es una bebida alcohólica, no destilada, de sabor amargo, que se fabrica con granos de cebada germinados u otros cereales cuyo almidón se fermenta en agua con levadura y se aromatiza a menudo con lúpulo, entre otras plantas.",
                            Imagen = "https://grupoleiros.com/image/catalog/leiros/GUBE0556-MLBE0062.png",
                            Title = "Cerveza Heineken",
                            price = 10m
                        },
                        new
                        {
                            Id = 2,
                            Description = "La cerveza ​ es una bebida alcohólica, no destilada, de sabor amargo, que se fabrica con granos de cebada germinados u otros cereales cuyo almidón se fermenta en agua con levadura y se aromatiza a menudo con lúpulo, entre otras plantas.",
                            Imagen = "https://statics.dinoonline.com.ar/imagenes/full_600x600_ma/3100751_f.jpg",
                            Title = "Cerveza Andes",
                            price = 10m
                        },
                        new
                        {
                            Id = 3,
                            Description = "La cerveza ​ es una bebida alcohólica, no destilada, de sabor amargo, que se fabrica con granos de cebada germinados u otros cereales cuyo almidón se fermenta en agua con levadura y se aromatiza a menudo con lúpulo, entre otras plantas.",
                            Imagen = "https://jumboargentina.vtexassets.com/arquivos/ids/588380-800-auto?v=637280467148530000&width=800&height=auto&aspect=true",
                            Title = "Cerveza Stella",
                            price = 9m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}