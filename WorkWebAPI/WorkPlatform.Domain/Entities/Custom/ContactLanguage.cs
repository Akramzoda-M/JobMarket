using System;
using System.Collections.Generic;
using System.Text;
using WorkPlatform.Domain.Entities.Base;
using WorkPlatform.Domain.Entities.Lookup;

namespace WorkPlatform.Domain.Entities.Custom
{
    public class ContactLanguage : BaseEntity
    {
        public Guid ContactId { get; set; }
        public Contact? Contact { get; set; }
        public Guid LanguageId { get; set; }
        public Language? Language { get; set; }
        public Guid LanguageLevelId { get; set; }
        public LanguageLevel? LanguageLevel { get; set; }
    }
}
