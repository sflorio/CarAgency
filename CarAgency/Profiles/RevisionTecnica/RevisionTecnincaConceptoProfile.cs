using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace CarAgency.Profiles.RevisionTecnica
{
    public class RevisionTecnincaConceptoProfile : Profile
    {
        public RevisionTecnincaConceptoProfile()
        {
            CreateMap<Domain.Models.RevisionTecnicaConcepto, Domain.DTO.RevisionTecnicaConcepto>();
            CreateMap<Domain.DTO.RevisionTecnicaConcepto, Domain.Models.RevisionTecnicaConcepto>();
        }
    }
}
