using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class PrecoMapping : Profile
    {
        public PrecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<PrecoResponse, PrecoModel>();
            CreateMap<PrecoModel, PrecoResponse>();
        }
    }
}
