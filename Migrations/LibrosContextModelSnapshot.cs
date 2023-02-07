﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api_librerias_paco.Models;

#nullable disable

namespace apilibreriaspaco.Migrations
{
    [DbContext(typeof(LibrosContext))]
    partial class LibrosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("api_librerias_paco.Models.Libros", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaPublicacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Paginas")
                        .HasColumnType("int");

                    b.Property<decimal?>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("enVenta")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Libro");
                });
#pragma warning restore 612, 618
        }
    }
}
