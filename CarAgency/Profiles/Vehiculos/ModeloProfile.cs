using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
namespace CarAgency.Profiles.Vehiculos
{
    public class ModeloProfile : Profile
    {
        public ModeloProfile() {
            CreateMap<Domain.Models.Vehiculos.Modelo, Domain.DTO.Vehiculos.Modelo>();
            CreateMap<Domain.DTO.Vehiculos.Modelo, Domain.Models.Vehiculos.Modelo>();
        }
    }
}
