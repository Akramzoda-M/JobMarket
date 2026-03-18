using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WorkPlatform.Domain.Entities.Base;

namespace WorkPlatform.Domain.Entities.Custom 
{
	[Display(Name = "Опыт вождения")]
	public class DriverLicense : BaseEntity 
	{
		public Guid ContactId { get; set; }
		public Contact? Contact { get; set; }
		public Guid RightsCategoryId { get; set; }
		public RightsCategory? RightsCategory { get; set; }
	}
}
