using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Direccion
    {
        [Key]
        public int DireccionId { get; set; }
        public Pais Pais { get; set; }
        public Provincia Provincia { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Calle { get; set; }

        public int NumeroCalle { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string CodigoPostal { get; set; }
    }
}
