using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class IsbnMapping : Profile
    {
        public IsbnMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<IsbnResponse, IsbnModel>();
            CreateMap<IsbnModel, IsbnResponse>();

            CreateMap<DimensionsResponse, DimensionsModel>();
            CreateMap<DimensionsModel, DimensionsResponse>();
        }
    }
}
