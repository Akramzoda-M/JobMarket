using WorkPlatform.Domain.Entities.Base;
using WorkPlatform.Domain.Entities.Lookup;

namespace WorkPlatform.Domain.Entities.Custom
{
    internal class VacancyRegion : BaseEntity
    {
        public Guid VacancyId { get; set; }
        public Vacancy? Vacancy { get; set; }
        public Guid RegionId { get; set; }
        public Region? Region { get; set; }
    }
}
