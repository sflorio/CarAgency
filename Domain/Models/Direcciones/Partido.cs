using Domain.Models.Direcciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models.Direcciones
{
    public class Partido
    {
        [Key]
        public int PartidoId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Descripcion { get; set; }

        public List<Localidad> Localidades { get; set; }
    }
}
