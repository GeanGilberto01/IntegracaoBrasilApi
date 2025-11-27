using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class TaxaMapping : Profile
    {
        public TaxaMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<TaxaResponse, TaxaModel>();
            CreateMap<TaxaModel, TaxaResponse>();
        }
    }
}
