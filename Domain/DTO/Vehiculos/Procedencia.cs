using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DTO.Vehiculos
{
    public class Procedencia
    {
        [Key]
        public int? ProcedenciaId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Descripcion { get; set; }
    }
}
