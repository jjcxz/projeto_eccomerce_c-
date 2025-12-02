using Ecommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Mappings
{
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
    public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Code).IsRequired().HasColumnType("varchar(50)");
            builder.Property(a => a.Discount).IsRequired().HasColumnType("float)");
            builder.Property(a => a.PaymentMethod).IsRequired().HasColumnType("int");
            builder.Property(a => a.Quantity).IsRequired().HasColumnType("int");
            builder.Property(a => a.Subtotal).IsRequired().HasColumnType("float");
            builder.Property(a => a.Total).IsRequired().HasColumnType("float");
            builder.Property(a => a.UnitPrice).IsRequired().HasColumnType("float");
           
        }
    }
}