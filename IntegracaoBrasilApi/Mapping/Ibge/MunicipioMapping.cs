using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class MunicipioMapping : Profile
    {
        public MunicipioMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<MunicipioResponse, MunicipioModel>();
            CreateMap<MunicipioModel, MunicipioResponse>();
        }
    }
}
