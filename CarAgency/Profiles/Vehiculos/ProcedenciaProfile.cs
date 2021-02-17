using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace CarAgency.Profiles.Vehiculos
{
    public class ProcedenciaProfile : Profile
    {
        public ProcedenciaProfile() {
            CreateMap<Domain.Models.Vehiculos.Procedencia, Domain.DTO.Vehiculos.Procedencia>();
            CreateMap<Domain.DTO.Vehiculos.Procedencia, Domain.Models.Vehiculos.Procedencia>();
        }

    }
}
