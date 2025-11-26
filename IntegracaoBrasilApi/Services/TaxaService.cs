using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;

namespace IntegracaoBrasilApi.Services
{
    public class TaxaService : ITaxaService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public TaxaService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<TaxaResponse>> BuscarTaxa(string sigla)
        {
            var response = await _brasilApi.BuscarTaxa(sigla);
            return _mapper.Map<ResponseGenerico<TaxaResponse>>(response);
        }

        public async Task<ResponseGenerico<List<TaxaResponse>>> BuscarTodasTaxas()
        {
            var response = await _brasilApi.BuscarTodasTaxas();
            return _mapper.Map<ResponseGenerico<List<TaxaResponse>>>(response);
        }
    }
}
