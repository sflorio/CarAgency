using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace Domain.Profiles.Vehiculos
{
    public class VehiculoProfile : AutoMapper.Profile
    {
        public VehiculoProfile() {
            CreateMap<Domain.Models.Vehiculos.Vehiculo, Domain.DTO.Vehiculos.Vehiculo>();
            CreateMap<Domain.DTO.Vehiculos.Vehiculo, Domain.Models.Vehiculos.Vehiculo>();
        }
    }
}
