using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class CambioMapping : Profile
    {
        public CambioMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<MoedaResponse, MoedaModel>();
            CreateMap<MoedaModel, MoedaResponse>();

            CreateMap<CambioResponse, CambioModel>();
            CreateMap<CambioModel, CambioResponse>();
            CreateMap<CotacoResponse, CotacoModel>();
            CreateMap<CotacoModel, CotacoResponse>();
        }
    }
}
