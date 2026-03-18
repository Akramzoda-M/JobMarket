using WorkPlatform.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using WorkPlatform.Domain.Entities.Lookup;

namespace WorkPlatform.Domain.Entities.Custom
{
    [Display(Name = "Контакт")]
	public class Contact : BaseEntity
	{
		public string Name { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string MiddleName { get; set; } = string.Empty;
		public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
		public string Email { get; set; } = string.Empty;
		public string PasswordHash { get; set; } = string.Empty;
		public string PhoneNumber { get; set; } = string.Empty;
		public string Telegram { get; set; } = string.Empty;
		public string WhatsApp { get; set; } = string.Empty;
		public Guid SearchStatusId { get; set; }
		public SearchStatus? SearchStatus { get; set; }
		public Guid EducationId { get; set; }
		public Education? Education { get; set; }
		public Guid CityId { get; set; }
		public Region? City { get; set; }
		public Guid RightsCategoryId { get; set; }
	}
}
