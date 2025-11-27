using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class ClimaMapping : Profile
    {
        public ClimaMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<ClimaResponse, ClimaModel>();
            CreateMap<ClimaModel, ClimaResponse>();
        }
    }
}
