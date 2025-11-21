using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class CnpjMapping : Profile
    {
        public CnpjMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<CnpjResponse, CnpjModel>();
            CreateMap<CnpjModel, CnpjResponse>();

            CreateMap<CnaesModel, CnaesResponse>();
            CreateMap<CnaesResponse, CnaesModel> ();

            CreateMap<SocioAdministradorModel, SocioAdministradorResponse>();
            CreateMap<SocioAdministradorResponse, SocioAdministradorModel>();

            CreateMap<RegimeTributarioModel, RegimeTributarioResponse>();
            CreateMap<RegimeTributarioResponse, RegimeTributarioModel>();
        }
    }
}