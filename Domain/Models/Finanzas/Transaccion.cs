using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models.Finanzas
{
    public class Transaccion : ClaseBase
    {
        [Key]
        public int TransaccionId { get; set; }

        public ConceptoFinanciero Concepto { get; set;}

        public TipoOperacion TipoOperacion { get; set; }

        public Cuenta Origen { get; set; }

        public Cuenta Destino { get; set; }

        [Column(TypeName = "Decimal(18,2)")]
        public decimal Monto { get; set; }

        public int? VehiculoId { get; set; }

    }
}
