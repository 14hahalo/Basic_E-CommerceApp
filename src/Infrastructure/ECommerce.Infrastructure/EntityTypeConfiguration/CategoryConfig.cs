using ECommerce.Domain.Entities;

namespace ECommerce.Infrastructure.EntityTypeConfiguration
{
    public class CategoryConfig : BaseEntityConfig<Category>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(X => X.Id);
            builder.Property(X => X.Id).IsRequired(true);

            builder.HasMany(x => x.Products)
                .WithMany(x => x.Categories);
                
            base.Configure(builder);
        }
    }
}
