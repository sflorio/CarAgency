﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models.Finanzas
{
    public class TipoOperacion : ClaseBase
    {
        [Key]
        public int TipoOperacionId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Descripcion { get; set; }
    }
}
