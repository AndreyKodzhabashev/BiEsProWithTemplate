namespace BiEsPro.Data.Models.FluentAPIModelConfigurations
{
    using BiEsPro.Data.Models.ItemElements;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ColorConfig : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder
                .HasIndex(x => x.Code)
                .IsUnique();
        }
    }
}
