using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WorkPlatform.Domain.Entities.Base;
using WorkPlatform.Domain.Entities.Lookup;

namespace WorkPlatform.Domain.Entities.Custom
{
	[Display(Name = "Навыки")]
	public class Scill : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string NormalizedName { get; set; } = string.Empty;
        public Guid CategoryId { get; set; }
        public JobCategory? JobCategory { get; set; }
        public bool IsApproved { get; set; }
    }
}
