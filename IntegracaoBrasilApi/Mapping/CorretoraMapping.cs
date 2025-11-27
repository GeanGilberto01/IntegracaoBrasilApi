using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class CorretoraMapping : Profile
    {
        public CorretoraMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<CorretoraResponse, CorretoraModel>();
            CreateMap<CorretoraModel, CorretoraResponse>();
        }
    }
}
