using Ecommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Mappings
{
    public class AddresMapping : IEntityTypeConfiguration<Address>
    {
    public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.City).IsRequired().HasColumnType("varchar(50)");
            builder.Property(a => a.Neighborhood).IsRequired().HasColumnType("varchar(50)");
            builder.Property(a => a.Number).IsRequired().HasColumnType("varchar(50)");
            builder.Property(a => a.StreetAddress).IsRequired().HasColumnType("varchar(150)");
           
        }
    }
}