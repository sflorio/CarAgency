using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace CarAgency.Profiles.Finanzas
{
    public class TransaccionProfile : Profile
    {
        public TransaccionProfile()
        {
            CreateMap<Domain.Models.Finanzas.Transaccion, Domain.DTO.Finanzas.Transaccion>();
            CreateMap<Domain.DTO.Finanzas.Transaccion, Domain.Models.Finanzas.Transaccion>();
        }
    }
}
