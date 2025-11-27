using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class TabelaMapping : Profile
    {
        public TabelaMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<TabelaResponse, TabelaModel>();
            CreateMap<TabelaModel, TabelaResponse>();
        }
    }
}
