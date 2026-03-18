using System;
using System.Collections.Generic;
using System.Text;
using WorkPlatform.Domain.Entities.Base;

namespace WorkPlatform.Domain.Entities.Custom
{
    public class RightsCategory : BaseEntity
    {
        public bool HaseOwnCar { get; set; } = false;
        public bool A { get; set; } = false;
        public bool B { get; set; } = false;
        public bool C { get; set; } = false;
        public bool D { get; set; } = false;
        public bool E { get; set; } = false;
        public bool BE { get; set; } = false;
        public bool CE { get; set; } = false;
        public bool DE { get; set; } = false;
        public bool TM { get; set; } = false;
        public bool TB { get; set; } = false;

    }
}
