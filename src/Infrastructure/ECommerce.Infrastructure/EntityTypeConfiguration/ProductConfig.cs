using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Infrastructure.EntityTypeConfiguration
{
    public class ProductConfig : BaseEntityConfig<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(X => X.Id);
            builder.Property(X => X.Id).IsRequired(true);
            base.Configure(builder);
        }
    }
}
