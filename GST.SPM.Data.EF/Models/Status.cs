using System.Collections.Generic;

namespace GST.SPM.Data.EF.Models
{
    public class Status : BaseEntity
    {
        public virtual ICollection<Group> Groups { get; set; }
    }
}