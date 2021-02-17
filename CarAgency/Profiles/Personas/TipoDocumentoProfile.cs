using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace CarAgency.Profiles.Personas
{
    public class TipoDocumentoProfile : Profile
    {
        public TipoDocumentoProfile()
        {
            CreateMap<Domain.Models.Personas.TipoDocumento, Domain.DTO.Personas.TipoDocumento>();
            CreateMap<Domain.DTO.Personas.TipoDocumento, Domain.Models.Personas.TipoDocumento>();
        }
    }
}
