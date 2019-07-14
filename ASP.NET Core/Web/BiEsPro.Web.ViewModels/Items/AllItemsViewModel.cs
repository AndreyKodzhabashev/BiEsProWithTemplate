namespace BiEsPro.Web.ViewModels.Items
{
    using BiEsPro.Data.Models.ItemElements;
    using BiEsPro.Services.Mapping;

    public class AllItemsViewModel : IMapFrom<Item>
    {
        public string Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Code { get; set; }

        public string ColorName { get; set; }

        public string ItemTypeName { get; set; }

        public decimal Quantity { get; set; }
    }
}
