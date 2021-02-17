using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace CarAgency.Profiles.Direcciones
{
    public class DireccionProfile : Profile
    {
        public DireccionProfile()
        {
            CreateMap<Domain.Models.Direcciones.Direccion, Domain.DTO.Direcciones.Direccion>();
            CreateMap<Domain.DTO.Direcciones.Direccion, Domain.Models.Direcciones.Direccion>();
        }
    }
}
