using System.Collections.Generic;

namespace GST.SPM.Data.EF.Models
{
    public class Project : BaseEntity
    {
        public virtual ICollection<ProjectDetails> ProjectDetails { get; set; }
    }
}