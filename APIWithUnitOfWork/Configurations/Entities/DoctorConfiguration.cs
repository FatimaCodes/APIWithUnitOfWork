using APIWithUnitOfWork.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIWithUnitOfWork.Configurations.Entities
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasData(
              new Doctor
              {
                  Id = 1,
                  Name = "Mina",
                  Surname = "Amini",
                  CountryId = 1,
                  CategortyId = 1,
                  Address = "Address1",
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
