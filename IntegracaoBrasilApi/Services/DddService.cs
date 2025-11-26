using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;

namespace IntegracaoBrasilApi.Services
{
    public class DddService : IDddService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public DddService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<DddResponse>> BuscarDdds(int ddd)
        {
            var response = await _brasilApi.BuscarDdds(ddd);
            return _mapper.Map<ResponseGenerico<DddResponse>>(response)
        }
    }
}
