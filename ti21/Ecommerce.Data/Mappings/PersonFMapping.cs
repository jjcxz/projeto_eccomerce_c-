using Ecommerce.Domain.Interfaces.Service;
using Ecommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Mappings
{
    public class PersonFMapping : IEntityTypeConfiguration<PersonF>
    {
        public void Configure(EntityTypeBuilder<PersonF> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CPF).IsRequired().HasColumnType("varchar(14)");
            builder.Property(p => p.Name).IsRequired().HasColumnType("varchar(60)");
        }
    }
}