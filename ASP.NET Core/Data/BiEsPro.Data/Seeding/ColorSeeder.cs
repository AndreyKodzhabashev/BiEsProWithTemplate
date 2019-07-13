namespace BiEsPro.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BiEsPro.Data.Models.ItemElements;

    public class ColorSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            await SeedColorsAsync(dbContext);
        }

        private static async Task SeedColorsAsync(ApplicationDbContext context)
        {
            if (context.Colors.Any() == false)
            {
                await context.Colors.AddAsync(new Color { Code = "Red", Name = "Red" });
                await context.Colors.AddAsync(new Color { Code = "White", Name = "White" });
                await context.Colors.AddAsync(new Color { Code = "Blue", Name = "Blue" });
                await context.Colors.AddAsync(new Color { Code = "Yellow", Name = "Yellow" });
                await context.Colors.AddAsync(new Color { Code = "Onyx", Name = "Onyx" });
                await context.Colors.AddAsync(new Color { Code = "Marble", Name = "Marble" });
                await context.Colors.AddAsync(new Color { Code = "Cherry", Name = "Cherry" });

                await context.SaveChangesAsync();
            }
        }
    }
}
