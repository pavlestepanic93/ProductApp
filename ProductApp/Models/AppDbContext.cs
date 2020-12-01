using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProizvodId = 1,
                Naziv = "Tastatura",
                Opis = "Bezicna",
                Kategorija = "Oprema",
                Proizvodjac = "Logitech",
                Dobavljac = "Tehnomanija",
                Cena = 2500
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProizvodId = 2,
                Naziv = "Mis",
                Opis = "Bezicni",
                Kategorija = "Oprema",
                Proizvodjac = "Logitech",
                Dobavljac = "Gigatron",
                Cena = 2000
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProizvodId = 3,
                Naziv = "Monitor",
                Opis = "Zicani",
                Kategorija = "Oprema",
                Proizvodjac = "Hp",
                Dobavljac = "Winwin",
                Cena = 12500
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProizvodId = 4,
                Naziv = "Zvucnici",
                Opis = "Zicani",
                Kategorija = "Oprema",
                Proizvodjac = "Sony",
                Dobavljac = "MusicStudio",
                Cena = 5500
            });
        }
    }

}


