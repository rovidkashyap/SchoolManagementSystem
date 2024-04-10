using SMS.Core.Common;

namespace SMS.Core.Entity.Academics
{
#nullable disable
    public class Class : AuditableEntity
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        
    }
}
