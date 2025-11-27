using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class FeriadoMapping : Profile
    {
        public FeriadoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<FeriadoResponse, FeriadoModel>();
            CreateMap<FeriadoModel, FeriadoResponse>();
        }
    }
}
