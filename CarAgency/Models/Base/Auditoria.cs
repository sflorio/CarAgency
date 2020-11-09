using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarAgency.Models
{
    public abstract class Auditoria
    {
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        
        [Column(TypeName = "nvarchar(20)")]
        public string CreateUser { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string UpdateUser { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DeleteDateTime { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string DeleteUser { get; set; }
        public bool Active { get; set; }
    }
}
