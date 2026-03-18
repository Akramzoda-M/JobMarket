using System.ComponentModel.DataAnnotations;
using WorkPlatform.Domain.Entities.Base;

namespace WorkPlatform.Domain.Entities.Custom
{
	[Display(Name = "Категории прав")]
	public class RightsCategory : BaseEntity
	{
		public string Code { get; set; } = string.Empty;

	}
}
