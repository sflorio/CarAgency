using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace CarAgency.Profiles.Personas
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Domain.Models.Personas.Usuario, Domain.DTO.Personas.Usuario>();
            CreateMap<Domain.DTO.Personas.Usuario, Domain.Models.Personas.Usuario>();
        }
    }
}
