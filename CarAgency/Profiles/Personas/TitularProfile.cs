using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace CarAgency.Profiles.Personas
{
    public class TitularProfile : Profile
    {
        public TitularProfile()
        {
            CreateMap<Domain.Models.Personas.Titular, Domain.DTO.Personas.Titular>();
            CreateMap<Domain.DTO.Personas.Titular, Domain.Models.Personas.Titular>();
        }
    }
}
