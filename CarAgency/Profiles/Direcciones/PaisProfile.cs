using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace CarAgency.Profiles.Direcciones
{
    public class PaisProfile : Profile
    {
        public PaisProfile()
        {
            CreateMap<Domain.Models.Direcciones.Pais, Domain.DTO.Direcciones.Pais>();
            CreateMap<Domain.DTO.Direcciones.Pais, Domain.Models.Direcciones.Pais>();
        }
    }
}
