using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace CarAgency.Profiles.Vehiculos
{
    public class TipoVehiculoProfile : Profile
    {
        public TipoVehiculoProfile() {
            CreateMap<Domain.Models.Vehiculos.TipoVehiculo, Domain.DTO.Vehiculos.TipoVehiculo>();
            CreateMap<Domain.DTO.Vehiculos.TipoVehiculo, Domain.Models.Vehiculos.TipoVehiculo>();
        }
    }
}
