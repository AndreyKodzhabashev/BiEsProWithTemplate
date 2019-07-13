namespace BiEsPro.Data.Common.Models
{
    using System.ComponentModel.DataAnnotations;

    public abstract class PropertyBaseModel<TKey> : BaseDeletableModel<TKey>
    {
        [Required(AllowEmptyStrings = false)]
        public string Code { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
    }
}
