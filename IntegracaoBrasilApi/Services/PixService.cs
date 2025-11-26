using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;

namespace IntegracaoBrasilApi.Services
{
    public class PixService : IPixService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public PixService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<List<PixParticipantesResponse>>> BuscarParticipantesPix()
        {
            var response = await _brasilApi.BuscarParticipantesPix();
            return _mapper.Map<ResponseGenerico<List<PixParticipantesResponse>>>(response);
        }
    }
}
