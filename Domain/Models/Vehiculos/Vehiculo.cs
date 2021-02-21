using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models.Finanzas;
using Domain.Models.Personas;

namespace Domain.Models.Vehiculos
{
    public class Vehiculo : ClaseBase
    {
        [Key]
        public int VehiculoId { get; set; }
        
        public string Dominio { get; set; }
        public Procedencia? Procedencia { get; set; }
        public DateTime FechaInscripcionInical { get; set; }
        public Marca Marca { get; set; }
        public Modelo Modelo { get; set; }
        public TipoVehiculo? TipoVehiculo { get; set; }

        [Column(TypeName = "tinyint")]
        public Int16 Ano { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string NumeroMotor { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string NumeroChasis { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string MarcaMotor { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string MarcaChasis { get; set; }

        public DateTime FechaAdquisicion { get; set; }

        public RevisionTecnica? RevisionTecnica { get; set; } 

        public List<Transaccion>? Transacciones { get; set; }

        public Titular? Titular { get; set; } 



    }
}
