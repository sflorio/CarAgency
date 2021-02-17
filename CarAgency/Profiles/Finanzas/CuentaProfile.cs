using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace CarAgency.Profiles.Finanzas
{
    public class CuentaProfile : Profile
    {
        public CuentaProfile()
        {
            CreateMap<Domain.Models.Finanzas.Cuenta, Domain.DTO.Finanzas.Cuenta>();
            CreateMap<Domain.DTO.Finanzas.Cuenta, Domain.Models.Finanzas.Cuenta>();
        }
    }
}
