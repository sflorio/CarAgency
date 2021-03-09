using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DTO.Direcciones
{
    public class Direccion
    {
        [Key]
        public int DireccionId { get; set; }
        public Pais Pais { get; set; }
        public Provincia Provincia { get; set; }
        public Partido Partido { get; set; }
        public Localidad Localidad { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Calle { get; set; }

        public Int16 NumeroCalle { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string CodigoPostal { get; set; }
    }
}
