using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace CarAgency.Models.Vehiculos
{
    public class TipoVehiculo
    {
        [Key]
        public int TipoVehiculoId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Descripcion { get; set; }

    }
}
