using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models.Vehiculos
{
    public class Modelo
    {

        [Key]
        public int ModeloId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Descripcion { get; set; }
    }
}
