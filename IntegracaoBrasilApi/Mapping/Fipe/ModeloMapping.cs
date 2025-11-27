using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class ModeloMapping : Profile
    {
        public ModeloMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<ModeloResponse, ModeloModel>();
            CreateMap<ModeloModel, ModeloResponse>();
        }
    }
}
