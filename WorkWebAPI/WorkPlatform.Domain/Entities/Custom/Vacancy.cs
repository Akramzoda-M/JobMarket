using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using WorkPlatform.Domain.Entities.Base;
using WorkPlatform.Domain.Entities.Lookup;

namespace WorkPlatform.Domain.Entities.Custom
{
	[Display(Name = "Вакансия")]
	internal class Vacancy : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Income { get; set; }
        public bool IncomeLevelIndicated { get; set; }
        public Guid CurrencyId { get; set; }
        public Currency? Currency { get; set; }
        public Guid WorkScheduleId { get; set; }
        public WorkSchedule? WorkSchedule { get; set; }
        public Guid WorkingHoursId { get; set; }
        public WorkingHoursPerDay? WorkingHoursPerDay { get; set; }
        public Guid ExperienceId { get; set; }
        public Experience? Experience { get; set; }
        public bool EveningOrNightShift { get; set; }
        public Guid WorkFormatId { get; set; }
        public WorkFormat? WorkFormat { get; set; }

    }
}
