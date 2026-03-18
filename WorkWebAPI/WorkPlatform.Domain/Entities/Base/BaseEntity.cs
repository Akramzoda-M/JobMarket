using System.ComponentModel.DataAnnotations;

namespace WorkPlatform.Domain.Entities.Base
{
    [Display(Name = "Базовый класс Entity")]
    public class BaseEntity
    {
        [Display(Name = "Id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Display(Name = "Создал")]
        public Guid? CreatedBy { get; set; }

        [Display(Name = "Дата создания")]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [Display(Name = "Изменил")]
        public Guid? UpdateBy { get; set; }

        [Display(Name = "Дата изменения")]
        public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
    }
}
