using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;

namespace IntegracaoBrasilApi.Services
{
    public class CorretoraService : ICorretoraService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public CorretoraService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<CorretoraResponse>> BuscarCorretora(string cnpj)
        {
            var response = await _brasilApi.BuscarCorretora(cnpj);
            return _mapper.Map<ResponseGenerico<CorretoraResponse>>(response);
        }

        public async Task<ResponseGenerico<List<CorretoraResponse>>> BuscarTodasCorretoras()
        {
            var response = await _brasilApi.BuscarTodasCorretoras();
            return _mapper.Map<ResponseGenerico<List<CorretoraResponse>>>(response);
        }
    }
}
