using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class MarcaMapping : Profile
    {
        public MarcaMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<MarcaResponse, MarcaModel>();
            CreateMap<MarcaModel, MarcaResponse>();
        }
    }
}
