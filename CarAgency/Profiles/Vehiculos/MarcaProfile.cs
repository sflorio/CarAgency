using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace CarAgency.Profiles.Vehiculos
{
    public class MarcaProfile : Profile
    {
        public MarcaProfile() {
            CreateMap<Domain.DTO.Vehiculos.Marca, Domain.Models.Vehiculos.Marca>();
            CreateMap<Domain.Models.Vehiculos.Marca, Domain.DTO.Vehiculos.Marca>();
        }

    }
}
