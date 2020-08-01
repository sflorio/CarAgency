using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarAgency.Models.Personas
{
    public class EstadoCivil
    {
        [Key]
        public int EstadoCivilId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Descripcion { get; set; }
    }
}
