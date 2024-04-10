using System.ComponentModel.DataAnnotations;

namespace SMS.Core.Common
{
    public class AuditableEntity : IAutditableEntity
    {
        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }

        [MaxLength(100)]
        [ScaffoldColumn(false)]
        public string CreatedBy { get; set; } = "Rovid Kashyap";

        [ScaffoldColumn(false)]
        public DateTime? UpdatedDate { get; set; }

        [MaxLength(100)]
        [ScaffoldColumn(false)]
        public string UpdatedBy { get; set; } = "Rovid Kashyap";
    }
}
