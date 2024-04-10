using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime ISTNow => DateTime.Now;
    }
}
