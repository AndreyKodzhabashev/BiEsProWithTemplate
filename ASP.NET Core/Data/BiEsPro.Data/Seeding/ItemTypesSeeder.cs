namespace BiEsPro.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BiEsPro.Data.Models.ItemElements;

    public class ItemTypesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            await SeedItemTypesAsync(dbContext);
        }

        private static async Task SeedItemTypesAsync(ApplicationDbContext context)
        {
            if (context.ItemTypes.Any() == false)
            {
                await context.ItemTypes.AddAsync(new ItemType { Code = "FnPl", Name = "Furniture panel" });
                await context.ItemTypes.AddAsync(new ItemType { Code = "HW", Name = "Hardware" });
                await context.ItemTypes.AddAsync(new ItemType { Code = "Acs", Name = "Accessory" });
                await context.ItemTypes.AddAsync(new ItemType { Code = "Wd", Name = "Real Wood" });
                await context.ItemTypes.AddAsync(new ItemType { Code = "Cmbl", Name = "Consumalbe" });
                await context.ItemTypes.AddAsync(new ItemType { Code = "Tl", Name = "Tool" });

                await context.SaveChangesAsync();
            }
        }
    }
}
