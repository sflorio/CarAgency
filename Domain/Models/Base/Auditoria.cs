using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public abstract class Auditoria
    {
        
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        
        [Column(TypeName = "nvarchar(20)")]
        public string CreateUser { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string UpdateUser { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeleteDateTime { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string DeleteUser { get; set; }
        public bool Active { get; set; }
    }

    public static class AuditoriaExtensions {
        public static void InitializeAddProperties(this Auditoria oAuditoria, string usuario)
        {
            oAuditoria.CreateDateTime = DateTime.Now;
            oAuditoria.CreateUser = usuario;
            oAuditoria.Active = true;
        }

        public static void InitializeUpdateProperties(this Auditoria oAuditoria, string usuario)
        {
            oAuditoria.UpdateDateTime = DateTime.Now;
            oAuditoria.UpdateUser = usuario;
        }
        public static void InitializeDeleteProperties(this Auditoria oAuditoria, string usuario)
        {
            oAuditoria.DeleteDateTime = DateTime.Now;
            oAuditoria.DeleteUser = usuario;
            oAuditoria.Active = false;
        }

    }


}
