using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DTO.Direcciones
{
    public class Pais
    {
        [Key]
        public int PaisId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Descripcion { get; set; }

        public List<Provincia> Provincias { get; set; }
    }
}
