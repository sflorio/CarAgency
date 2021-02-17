﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DTO.Vehiculos
{
    public class Marca
    {
        [Key]
        public int MarcaId { get; set; }

        
        [Column(TypeName ="nvarchar(200)")]
        public string Descripcion { get; set; }

        public List<Modelo> Modelos { get; set; }

    }
}