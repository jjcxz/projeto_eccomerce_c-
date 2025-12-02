using Ecommerce.Domain.Interfaces.Service;
using Ecommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Brand).IsRequired().HasColumnType("varchar(30)");
            builder.Property(p => p.Category).IsRequired().HasColumnType("varchar(70)");
            builder.Property(p => p.Color).IsRequired().HasColumnType("varchar(50)");
            builder.Property(p => p.Description).IsRequired().HasColumnType("varchar(150)");
            builder.Property(p => p.Material).IsRequired().HasColumnType("varchar(30)");
            builder.Property(p => p.Model).IsRequired().HasColumnType("varchar(30)");
            builder.Property(p => p.Price).IsRequired().HasColumnType("float");
            builder.Property(p => p.Name).IsRequired().HasColumnType("varchar(50)");
        }
    }
}