using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace CarAgency.Models
{
    public abstract class Auditoria
    {
        
        public DateTime CreateDateTime { get; set; }
        public DateTime CreateUser { get; set; }

        public DateTime UpdateDateTime { get; set; }
        public DateTime UpdateUser { get; set; }

        public DateTime DeleteDateTime { get; set; }
        public DateTime DeleteUser { get; set; }
        public bool Active { get; set; }
    }
}
