using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WorkPlatform.Domain.Entities.Base;

namespace WorkPlatform.Domain.Entities.Custom
{
	[Display(Name = "Отклик")]
	public class Application : BaseEntity
    {
		public Guid VacancyId { get; set; }
		public Vacancy? Vacancy { get; set; }
		public Guid ResumeId { get; set; }
		public Resume? Resume { get; set; }
		public string Comment { get; set; } = string.Empty;

	}
}
