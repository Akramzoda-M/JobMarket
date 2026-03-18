using System;
using System.Collections.Generic;
using System.Text;
using WorkPlatform.Domain.Entities.Base;

namespace WorkPlatform.Domain.Entities.Lookup
{
    public class Region : BaseLookup
    {
        public Guid CountryId { get; set; }
        public Country? Country { get; set; }

    }
}
