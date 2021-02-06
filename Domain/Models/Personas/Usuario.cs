using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models.Personas
{
    public class Usuario: ClaseBase
    {
        [Key]
        public int UsuarioId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string UserName { get; set; }
    }
}
