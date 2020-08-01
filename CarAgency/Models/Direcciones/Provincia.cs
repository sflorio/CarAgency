using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarAgency.Models
{
    public class Provincia
    {
        [Key]
        public int ProvinciaId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Descripcion { get; set; }
        public Pais Pais { get; set; }

        public List<Partido> Partidos { get; set; }
    }
}
