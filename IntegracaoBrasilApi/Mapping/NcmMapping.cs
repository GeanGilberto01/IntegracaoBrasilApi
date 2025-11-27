using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class NcmMapping : Profile
    {
        public NcmMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<NcmResponse, NcmModel>();
            CreateMap<NcmModel, NcmResponse>();
        }
    }
}
