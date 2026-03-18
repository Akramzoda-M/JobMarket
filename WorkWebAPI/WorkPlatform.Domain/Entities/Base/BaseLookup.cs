using System.ComponentModel.DataAnnotations;

namespace WorkPlatform.Domain.Entities.Base
{
    [Display(Name = "Базовый класс Lookup")]
    public class BaseLookup : BaseEntity
    {
        [Display(Name = "Название")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Описание")]
        public string? Description { get; set; } = string.Empty;
    }
}
