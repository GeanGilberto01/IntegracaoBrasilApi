using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class MoedaMapping : Profile
    {
        public MoedaMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<MoedaResponse, MoedaModel>();
            CreateMap<MoedaModel, MoedaResponse>();
        }
    }
}
