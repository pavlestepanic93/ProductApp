﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductApp.Models;

namespace ProductApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ProductApp.Models.Product", b =>
                {
                    b.Property<int>("ProizvodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Cena")
                        .HasColumnType("float");

                    b.Property<string>("Dobavljac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kategorija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Proizvodjac")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProizvodId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProizvodId = 1,
                            Cena = 2500.0,
                            Dobavljac = "Tehnomanija",
                            Kategorija = "Oprema",
                            Naziv = "Tastatura",
                            Opis = "Bezicna",
                            Proizvodjac = "Logitech"
                        },
                        new
                        {
                            ProizvodId = 2,
                            Cena = 2000.0,
                            Dobavljac = "Gigatron",
                            Kategorija = "Oprema",
                            Naziv = "Mis",
                            Opis = "Bezicni",
                            Proizvodjac = "Logitech"
                        },
                        new
                        {
                            ProizvodId = 3,
                            Cena = 12500.0,
                            Dobavljac = "Winwin",
                            Kategorija = "Oprema",
                            Naziv = "Monitor",
                            Opis = "Zicani",
                            Proizvodjac = "Hp"
                        },
                        new
                        {
                            ProizvodId = 4,
                            Cena = 5500.0,
                            Dobavljac = "MusicStudio",
                            Kategorija = "Oprema",
                            Naziv = "Zvucnici",
                            Opis = "Zicani",
                            Proizvodjac = "Sony"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
