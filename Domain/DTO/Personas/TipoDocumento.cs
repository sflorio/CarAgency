using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DTO.Personas
{
    public class TipoDocumento
    {
        [Key]
        public int TipoDocumentoId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Descripcion { get; set; }
    }
}
