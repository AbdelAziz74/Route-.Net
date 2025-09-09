using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_03.DAL.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; } // PK
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }  // User Id
        public DateTime CreatedOn { get; set; }
        public int LastModifiedBy { get; set; } // User Id
        public DateTime LastModifiedOn { get; set; }
    }
}
