using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace CarAgency.Profiles.Personas
{
    public class EstadoCivilProfile : Profile
    {
        public EstadoCivilProfile()
        {
            CreateMap<Domain.Models.Personas.EstadoCivil, Domain.DTO.Personas.EstadoCivil>();
            CreateMap<Domain.DTO.Personas.EstadoCivil, Domain.Models.Personas.EstadoCivil>();
        }
    }
}
