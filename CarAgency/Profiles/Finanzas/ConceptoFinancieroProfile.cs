using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace CarAgency.Profiles.Finanzas
{
    public class ConceptoFinancieroProfile : Profile
    {
        public ConceptoFinancieroProfile()
        {
            CreateMap<Domain.Models.Finanzas.ConceptoFinanciero, Domain.DTO.Finanzas.ConceptoFinanciero>();
            CreateMap<Domain.DTO.Finanzas.ConceptoFinanciero, Domain.Models.Finanzas.ConceptoFinanciero>();
        }
    }
}
