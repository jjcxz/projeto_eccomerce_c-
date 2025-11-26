using Ecommerce.Domain.Interfaces.Service;
using Ecommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Mappings
{
    public class PersonMapping : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Email).IsRequired().HasColumnType("varchar(200)");
            builder.Property(p => p.Address).IsRequired().HasColumnType("varchar(300)");
            builder.Property(p => p.Phone).IsRequired().HasColumnType("varchar(20)");
        }
    }
}