using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models.Finanzas;
using Domain.Models.Personas;

namespace Domain.DTO.Vehiculos
{
    public class Vehiculo : ClaseBase
    {
        [Key]
        public int? VehiculoId { get; set; }
        [Required]
        public string Dominio { get; set; }
        public Procedencia? Procedencia { get; set; }
        public DateTime FechaInscripcionInical { get; set; }
        public Marca Marca { get; set; }
        public Modelo Modelo { get; set; }

        [Required]
        public Int16? Ano { get; set; }
        public string NumeroMotor { get; set; }
        public string NumeroChasis { get; set; }
        public string MarcaMotor { get; set; }
        public string MarcaChasis { get; set; }
        public DateTime? FechaAdquisicion { get; set; }
        public RevisionTecnica? RevisionTecnica { get; set; } 
        public List<Transaccion>? Transacciones { get; set; }
        public Titular? Titular { get; set; } 
    }



    public class VehiculoViewDTO : ClaseBase
    {
        [Key]
        public int VehiculoId { get; set; }
        public string Dominio { get; set; }
        public string Procedencia { get; set; }
        public DateTime FechaInscripcionInical { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Int16? Ano { get; set; }
        public string NumeroMotor { get; set; }
        public string NumeroChasis { get; set; }
        public string MarcaMotor { get; set; }
        public string MarcaChasis { get; set; }
        public DateTime? FechaAdquisicion { get; set; }
        public string Titular { get; set; }
    }


}
