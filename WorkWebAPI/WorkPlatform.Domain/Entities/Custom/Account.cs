using WorkPlatform.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace WorkPlatform.Domain.Entities.Custom
{
	[Display(Name = "Контрагент")]
	public class Account : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

    }
}
