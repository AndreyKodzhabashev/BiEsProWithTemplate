namespace BiEsPro.Data.Models.FluentAPIModelConfigurations
{
    using BiEsPro.Data.Models.ItemElements;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ItemTypeConfig : IEntityTypeConfiguration<ItemType>
    {
        public void Configure(EntityTypeBuilder<ItemType> builder)
        {
            builder
                .HasIndex(x => x.Code)
                .IsUnique();
        }
    }
}
