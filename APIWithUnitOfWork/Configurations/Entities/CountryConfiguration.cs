using APIWithUnitOfWork.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIWithUnitOfWork.Configurations.Entities
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
          
    }
}
