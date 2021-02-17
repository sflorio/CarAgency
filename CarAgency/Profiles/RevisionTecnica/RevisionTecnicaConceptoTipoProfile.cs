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
            CreateMap<Domain.Models.RevisionTecnicaConceptoTipo, Domain.DTO.RevisionTecnicaConceptoTipo>();
            CreateMap<Domain.DTO.RevisionTecnicaConceptoTipo, Domain.Models.RevisionTecnicaConceptoTipo>();
        }
    }
}
