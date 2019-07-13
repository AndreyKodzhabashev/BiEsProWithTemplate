namespace BiEsPro.Data.Models.ItemElements
{
    using System.Collections.Generic;

    using BiEsPro.Data.Common.Models;

    public class Color : PropertyBaseModel<string>
    {
        public Color()
        {
            this.Items = new HashSet<Item>();
        }

        public IEnumerable<Item> Items { get; set; }
    }
}
