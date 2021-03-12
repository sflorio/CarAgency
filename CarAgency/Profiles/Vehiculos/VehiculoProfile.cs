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
            CreateMap<Domain.Models.Vehiculos.Vehiculo, Domain.DTO.Vehiculos.VehiculoViewDTO>()
                .ForMember(e => e.Marca, opt => opt.MapFrom(a => a.Marca.Descripcion))
                .ForMember(e => e.Modelo, opt => opt.MapFrom(a => a.Modelo.Descripcion))
                .ForMember(e => e.Procedencia, opt => opt.MapFrom(a => a.Procedencia.Descripcion))
                .ForMember(e => e.Titular, opt => opt.MapFrom(a => a.Titular.Apellido + ", " + a.Titular.Nombre));

            
        }
    }
}
