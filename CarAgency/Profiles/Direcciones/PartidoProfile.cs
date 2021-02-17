using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace CarAgency.Profiles.Direcciones
{
    public class PartidoProfile : Profile
    {
        public PartidoProfile()
        {
            CreateMap<Domain.Models.Direcciones.Partido, Domain.DTO.Direcciones.Partido>();
            CreateMap<Domain.DTO.Direcciones.Partido, Domain.Models.Direcciones.Partido>();
        }
    }
}
