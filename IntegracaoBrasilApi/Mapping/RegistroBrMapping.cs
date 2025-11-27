using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class RegistroBrMapping : Profile
    {
        public RegistroBrMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<RegistroBrResponse, RegistroBrModel>();
            CreateMap<RegistroBrModel, RegistroBrResponse>();
        }
    }
}
