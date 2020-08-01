using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarAgency.Models
{
    public class RevisionTecnicaConcepto : ClaseBase
    {
        [Key]
        public int RevisionTecnicaConceptoId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Descripcion { get; set; }
        public RevisionTecnicaConceptoTipo Tipo { get; set; }
    }
}
