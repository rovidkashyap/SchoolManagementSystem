﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Services
{
    public interface IDateTimeService
    {
        DateTime ISTNow { get; }
    }
}
