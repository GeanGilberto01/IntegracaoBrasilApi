using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class EstadoMapping : Profile
    {
        public EstadoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EstadoResponse, EstadoModel>();
            CreateMap<EstadoModel, EstadoResponse>();

            CreateMap<RegiaoResponse, RegiaoModel>();
            CreateMap<RegiaoModel, RegiaoResponse>();
        }
    }
}
