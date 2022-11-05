using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace APIWithUnitOfWork.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Turkey",
                    ShortName = "TR"
                },
                new Country
                {
                    Id = 2,
                    Name = "Iran",
                    ShortName = "IR"
                },
                new Country
                {
                    Id = 3,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 4,
                    Name = "Bahamas",
                    ShortName = "BS"
                },
                new Country
                {
                    Id = 5,
                    Name = "Cayman Island",
                    ShortName = "CI"
                }
            );

            builder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "rhinoplasty",
                },
                new Category
                {
                    Id = 2,
                    Name = "Dentist",
                },
                new Category
                {
                    Id = 3,
                    Name = "Cardiologist",
                },
                new Category
                {
                    Id = 4,
                    Name = "Urology",
                },
                new Category
                {
                    Id = 5,
                    Name = "Oncology",
                },
                new Category
                {
                    Id = 6,
                    Name = "exp-spine-surgery",
                }
            );
            builder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = 1,
                    Name = "Mina",
                    Surname = "Amini",
                    CountryId = 1,  
                    CategortyId = 1,
                    Address= "Address1",
                    Rating = 5
                },
                new Doctor
                {
                    Id = 2,
                    Name = "Andi",
                    Surname = "Naiak",
                    CountryId = 1,
                    CategortyId = 1,
                    Address = "Address1",
                    Rating = 4.4
                },
                new Doctor
                {
                    Id = 3,
                    Name = "Sara",
                    Surname = "Doniat",
                    CountryId = 1,
                    CategortyId = 1,
                    Address = "Address1",
                    Rating = 3.5
                },
                new Doctor
                {
                    Id = 4,
                    Name = "John",
                    Surname = "Wilson",
                    CountryId = 2,
                    CategortyId = 4,
                    Address = "Address1",
                    Rating = 4.9
                },
                new Doctor
                {
                    Id = 5,
                    Name = "Adams",
                    Surname = "Robinson",
                    CountryId = 3,
                    CategortyId = 5,
                    Address = "Address1",
                    Rating = 3.8
                }
            );
        }
    }

}
