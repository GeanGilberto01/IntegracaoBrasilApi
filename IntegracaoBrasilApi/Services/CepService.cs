using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;

namespace IntegracaoBrasilApi.Services
{
    public class CepService : ICepService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public CepService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<CepResponse>> BuscarCep(string cep)
        {
            var endereco = await _brasilApi.BuscarCep(cep);

            return _mapper.Map<ResponseGenerico<CepResponse>>(endereco);
        }

        public async Task<ResponseGenerico<CepResponse>> BuscarCepV2(string cep)
        {
            var endereco = await _brasilApi.BuscarCepV2(cep);

            return _mapper.Map<ResponseGenerico<CepResponse>>(endereco);
        }
    }
}
