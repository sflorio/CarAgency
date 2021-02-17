using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace CarAgency.Profiles.Personas
{
    public class PersonaProfile : Profile
    {
        public PersonaProfile()
        {
            CreateMap<Domain.Models.Personas.Persona, Domain.DTO.Personas.Persona>();
            CreateMap<Domain.DTO.Personas.Persona, Domain.Models.Personas.Persona>();
        }
            
    }
}
