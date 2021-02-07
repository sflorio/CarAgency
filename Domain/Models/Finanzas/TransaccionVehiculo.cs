using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.Finanzas
{
    public class TransaccionVehiculo : ClaseBase
    {
        [Key]
        public int TransaccionVehiculoId { get; set; }
        public int TransaccionId { get; set; }
        public int VehiculoId { get; set; }
    }
}
