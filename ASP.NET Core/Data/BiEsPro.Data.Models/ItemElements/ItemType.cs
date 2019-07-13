namespace BiEsPro.Data.Models.ItemElements
{
    using System.Collections.Generic;

    using BiEsPro.Data.Common.Models;

    public class ItemType : PropertyBaseModel<string>
    {
        public ItemType()
        {
            this.Items = new HashSet<Item>();
        }

        public IEnumerable<Item> Items { get; set; }
    }
}
