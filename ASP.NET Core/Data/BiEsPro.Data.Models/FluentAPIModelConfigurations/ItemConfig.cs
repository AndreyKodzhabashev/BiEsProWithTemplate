namespace BiEsPro.Data.Models.FluentAPIModelConfigurations
{

    using BiEsPro.Data.Models.ItemElements;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ItemConfig : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasOne(x => x.Color)
                  .WithMany(x => x.Items)
                  .HasForeignKey(x => x.ColorId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.ItemType)
                 .WithMany(x => x.Items)
                 .HasForeignKey(x => x.ItemTypeId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
