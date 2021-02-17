using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace CarAgency.Profiles.Finanzas
{
    public class TipoOperacionProfile : Profile
    {
        public TipoOperacionProfile()
        {
            CreateMap<Domain.Models.Finanzas.TipoOperacion, Domain.DTO.Finanzas.TipoOperacion>();
            CreateMap<Domain.DTO.Finanzas.TipoOperacion, Domain.Models.Finanzas.TipoOperacion>();
        }
    }
}
