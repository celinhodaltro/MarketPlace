using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Entities
{
    public class DefaultDbo
    {
        public Guid UniqueId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
