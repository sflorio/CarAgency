﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarAgency.Models
{
    public class RevisionTecnicaConceptoTipo : ClaseBase
    {
        [Key]
        public int RevisionTecnicaConceptoTipoId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Descripcion { get; set; }
    }
}
