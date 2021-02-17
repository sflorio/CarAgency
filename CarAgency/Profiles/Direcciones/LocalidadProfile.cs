using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace CarAgency.Profiles.Direcciones
{
    public class LocalidadProfile : Profile
    {
        public LocalidadProfile()
        {
            CreateMap<Domain.Models.Direcciones.Localidad, Domain.DTO.Direcciones.Localidad>();
            CreateMap<Domain.DTO.Direcciones.Localidad, Domain.Models.Direcciones.Localidad>();
        }
    }
}
