using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class CidadeMapping : Profile
    {
        public CidadeMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<CidadeResponse, CidadeModel>();
            CreateMap<CidadeModel, CidadeResponse>();
        }
    }
}
