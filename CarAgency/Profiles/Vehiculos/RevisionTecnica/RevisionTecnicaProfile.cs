using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace CarAgency.Profiles.RevisionTecnica
{
    public class RevisionTecnicaProfile : Profile
    {
        public RevisionTecnicaProfile()
        {
            CreateMap<Domain.Models.Vehiculos.RevisionTecnica, Domain.DTO.Vehiculos.RevisionTecnica>();
            CreateMap<Domain.DTO.Vehiculos.RevisionTecnica, Domain.Models.Vehiculos.RevisionTecnica>();
        }
    }
}
