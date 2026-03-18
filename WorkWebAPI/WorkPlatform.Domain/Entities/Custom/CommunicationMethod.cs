using System;
using System.Collections.Generic;
using System.Text;
using WorkPlatform.Domain.Entities.Base;

namespace WorkPlatform.Domain.Entities.Custom
{
    public class CommunicationMethod : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string URL { get; set; } = string.Empty;
        public Guid ContactId { get; set; }
        public Contact? Contact { get; set; }
    }
}
