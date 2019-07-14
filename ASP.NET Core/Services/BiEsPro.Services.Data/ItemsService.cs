namespace BiEsPro.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using BiEsPro.Data.Common.Repositories;
    using BiEsPro.Data.Models.ItemElements;
    using BiEsPro.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class ItemsService : IItemsService
    {
        private readonly IDeletableEntityRepository<Item> repo;

        public ItemsService(IDeletableEntityRepository<Item> repo)
        {
            this.repo = repo;
        }

        public Task CreateItemAsync<TViewModel>()
        {
            throw new NotImplementedException();
        }

        public Task DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<TViewModel> FindItemAsync<TViewModel>(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TViewModel>> GetAllItemColorsAsync<TViewModel>()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TViewModel>> GetAllItemsAsync<TViewModel>()
        {
            var allItems = await this.repo.All().To<TViewModel>().ToListAsync();
            return allItems;
        }

        public Task<IEnumerable<TViewModel>> GetAllItemTypesAsync<TViewModel>()
        {
            throw new NotImplementedException();
        }

        public bool ItemExists(string id)
        {
            throw new NotImplementedException();
        }
    }
}
