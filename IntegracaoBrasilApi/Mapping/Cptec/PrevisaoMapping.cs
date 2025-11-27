using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class PrevisaoMapping : Profile
    {
        public PrevisaoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<PrevisaoResponse, PrevisaoModel>();
            CreateMap<PrevisaoModel, PrevisaoResponse>();

            CreateMap<TempoResponse, TempoModel>();
            CreateMap<TempoModel, TempoResponse>();
        }
    }
}
