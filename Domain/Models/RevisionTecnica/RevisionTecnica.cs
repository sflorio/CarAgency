using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class RevisionTecnica : ClaseBase
    {
        [Key]
        public int RevisionTecnicaId { get; set; }
        List<RevisionTecnicaConcepto> Conceptos { get; set; }
    }
}
