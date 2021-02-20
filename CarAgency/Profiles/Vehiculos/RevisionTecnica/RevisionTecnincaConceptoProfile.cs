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
            CreateMap<Domain.Models.Vehiculos.RevisionTecnicaConcepto, Domain.DTO.Vehiculos.RevisionTecnicaConcepto>();
            CreateMap<Domain.DTO.Vehiculos.RevisionTecnicaConcepto, Domain.Models.Vehiculos.RevisionTecnicaConcepto>();
        }
    }
}
