using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class CepMapping : Profile
    {
        public CepMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<CepResponse, CepModel>();
            CreateMap<CepModel, CepResponse>();

            CreateMap<LocalizacaResponse, LocalizacaoModel>();
            CreateMap<LocalizacaoModel, LocalizacaResponse>();
            CreateMap<CoordenadasResponse, CoordenadasModel>();
            CreateMap<CoordenadasModel, CoordenadasResponse>();
        }
    }
}
