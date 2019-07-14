namespace BiEsPro.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IItemsService
    {
        Task<IEnumerable<TViewModel>> GetAllItemColorsAsync<TViewModel>();

        Task<IEnumerable<TViewModel>> GetAllItemTypesAsync<TViewModel>();

        Task<IEnumerable<TViewModel>> GetAllItemsAsync<TViewModel>();

        Task CreateItemAsync<TViewModel>();

        Task<TViewModel> FindItemAsync<TViewModel>(string id);

        //Task<ItemDetailsDto> GetItemDetails();

        Task DeleteItemAsync(string id);

        bool ItemExists(string id);
    }
}
