using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Common
{
    public interface IAutditableEntity
    {
        DateTime CreateDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set;}
        string UpdatedBy { get; set; }
    }
}
