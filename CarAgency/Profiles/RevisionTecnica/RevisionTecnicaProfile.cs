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
            CreateMap<Domain.Models.RevisionTecnica, Domain.DTO.RevisionTecnica>();
            CreateMap<Domain.DTO.RevisionTecnica, Domain.Models.RevisionTecnica>();
        }
    }
}
