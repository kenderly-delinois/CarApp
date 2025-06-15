using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarApp.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace CarApp.Data
{
    public class CarContext:DbContext
    {
        public DbSet<Car> Carset { get; set; } // table for car

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("data source = KENNY; initial catalog = DealershipIventory; integrated security = True; encrypt = False; trustservercertificate = True; MultipleActiveResultSets = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
            new Car
            { 
                CarId = 1,
                CarVin = "1HGCG1659WA029633",
                CarMake = "Honda",
                CarModel = "Civic",
                CarYear = 2000,
                CarPrice = 7000
            },

            new Car
            {
                CarId = 2,
                CarVin = "1HGCG1659WA027633",
                CarMake = "Ford",
                CarModel = "Mustang",
                CarYear = 2005,
                CarPrice = 9000
            },

            new Car
            {
                CarId = 3,
                CarVin = "1HGCG1659WA111133",
                CarMake = "Kia",
                CarModel = "Forte",
                CarYear = 2010,
                CarPrice = 8000
            },

            new Car
            {
                CarId = 4,
                CarVin = "1HGCG1659WA222533",
                CarMake = "Toyota",
                CarModel = "Camry",
                CarYear = 2000,
                CarPrice = 7000
            }
            );
        }

    }
}
