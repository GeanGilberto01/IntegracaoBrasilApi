using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Mapping
{
    public class PixParticipantesMapping : Profile
    {
        public PixParticipantesMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<PixParticipantesResponse, PixParticipantesModel>();
            CreateMap<PixParticipantesModel, PixParticipantesResponse>();
        }
    }
}
