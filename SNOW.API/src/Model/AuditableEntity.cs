using System;
using System.Collections.Generic;
using System.Text;

namespace SNOW.API.Core.Model
{
    public abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity
    {
       
        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }
    }
}
