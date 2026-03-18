using System;
using System.Collections.Generic;
using System.Text;
using WorkPlatform.Domain.Entities.Base;

namespace WorkPlatform.Domain.Entities.Custom
{
    public class Resume : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid ContactId { get; set; }
        public Contact? Contact { get; set; }

    }
}
