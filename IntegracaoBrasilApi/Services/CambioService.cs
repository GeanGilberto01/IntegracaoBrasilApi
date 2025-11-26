using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;

namespace IntegracaoBrasilApi.Services
{
    public class CambioService : ICambioService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public CambioService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<List<MoedaResponse>>> BuscarMoedas()
        {
            var moedas = await _brasilApi.BuscarMoedas();
            return _mapper.Map<ResponseGenerico<List<MoedaResponse>>>(moedas);
        }

        public async Task<ResponseGenerico<CambioResponse>> BuscarCambio(string moeda, string data)
        {
            var cambios = await _brasilApi.BuscarCambio(moeda, data);
            return _mapper.Map<ResponseGenerico<CambioResponse>>(cambios);
        }
    }
}
