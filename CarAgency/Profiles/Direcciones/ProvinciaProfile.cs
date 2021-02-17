using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace CarAgency.Profiles.Direcciones
{
    public class ProvinciaProfile : Profile
    {
        public ProvinciaProfile()
        {
            CreateMap<Domain.Models.Direcciones.Provincia, Domain.DTO.Direcciones.Provincia>();
            CreateMap<Domain.DTO.Direcciones.Provincia, Domain.Models.Direcciones.Provincia>();
        }
    }
}
