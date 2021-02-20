using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace CarAgency.Profiles.RevisionTecnica
{
    public class RevisionTecnicaConceptoTipoProfile :Profile
    {
        public RevisionTecnicaConceptoTipoProfile()
        {
            CreateMap<Domain.Models.Vehiculos.RevisionTecnicaConceptoTipo, Domain.DTO.Vehiculos.RevisionTecnicaConceptoTipo>();
            CreateMap<Domain.DTO.Vehiculos.RevisionTecnicaConceptoTipo, Domain.Models.Vehiculos.RevisionTecnicaConceptoTipo>();
        }
    }
}
