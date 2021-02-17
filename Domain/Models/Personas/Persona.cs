using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models.Direcciones;
namespace Domain.Models.Personas
{
    public class Persona : ClaseBase
    {
        [Key]
        public int PersonaId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Nombre { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Apellido { get; set; }
        public Direccion Direccion { get; set; }
        public TipoDocumento TipoDocumento { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string NumeroDocumento { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string CUIL { get; set; }

        public EstadoCivil EstadoCivil { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public Pais Nacionalidad { get; set; }
    }
}
