using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DTO.Finanzas
{
    public class Cuenta : ClaseBase
    {
        [Key]
        public int CuentaId { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Descripcion { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string NumeroCuenta { get; set; }
    }
}
