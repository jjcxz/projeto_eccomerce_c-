using Ecommerce.Domain.Interfaces.Service;
using Ecommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Mappings
{
    public class PersonJMapping : IEntityTypeConfiguration<PersonJ>
    {
        public void Configure(EntityTypeBuilder<PersonJ> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CNPJ).IsRequired().HasColumnType("varchar(18)");
            builder.Property(p => p.BusinessName).IsRequired().HasColumnType("varchar(50)");
        }
    }
}