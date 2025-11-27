using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class OndasMapping : Profile
    {
        public OndasMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<OndasResponse, OndasModel>();
            CreateMap<OndasModel, OndasResponse>();

            CreateMap<OndaResponse, OndaModel>();
            CreateMap<OndaModel, OndaResponse>();

            CreateMap<DadosOndaResponse, DadosOndaModel>();
            CreateMap<DadosOndaModel, DadosOndaResponse>();
        }
    }
}
