using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DTO.Finanzas
{
    public class ConceptoFinanciero : ClaseBase
    {
        [Key]
        public int ConceptoFinancieroId { get; set; }
        
        [Column(TypeName = "nvarchar(200)")]
        public string Descripcion { get; set; }
    }
}
