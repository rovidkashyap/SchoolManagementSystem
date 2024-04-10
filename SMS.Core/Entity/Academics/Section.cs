﻿using SMS.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Entity.Academics
{
    public class Section : AuditableEntity
    {
        public int SectionId { get; set; }
        public string SectionName { get; set; }
    }
}
