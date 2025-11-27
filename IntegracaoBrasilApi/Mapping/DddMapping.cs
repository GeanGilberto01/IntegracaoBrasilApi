using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class DddMapping : Profile
    {
        public DddMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<DddResponse, DddModel>();
            CreateMap<DddModel, DddResponse>();
        }
    }
}
