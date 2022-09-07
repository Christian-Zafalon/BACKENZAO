﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Data;

namespace WebAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("WebAPI.Data.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Estoque")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<decimal>("Preco")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Estoque = 5,
                            Nome = "Trator",
                            Preco = 1000000.00m
                        },
                        new
                        {
                            Id = 2,
                            Estoque = 10,
                            Nome = "Ventilador Agricola",
                            Preco = 156000.00m
                        },
                        new
                        {
                            Id = 3,
                            Estoque = 50,
                            Nome = "Ração",
                            Preco = 3000.00m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
