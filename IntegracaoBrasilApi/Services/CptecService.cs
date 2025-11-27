using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;

namespace IntegracaoBrasilApi.Services
{
    public class CptecService : ICptecService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public CptecService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<List<CidadeResponse>>> BuscarTodasCidades()
        {
            var response = await _brasilApi.BuscarTodasCidades();
            return _mapper.Map<ResponseGenerico<List<CidadeResponse>>>(response);
        }

        public async Task<ResponseGenerico<CidadeResponse>> BuscarCidade(string nomeCidade)
        {
            var response = await _brasilApi.BuscarCidade(nomeCidade);
            return _mapper.Map<ResponseGenerico<CidadeResponse>>(response);
        }

        public async Task<ResponseGenerico<ClimaResponse>> BuscarCondicaoAeroporto(string codicoIcao)
        {
            var response = await _brasilApi.BuscarCondicaoAeroporto(codicoIcao);
            return _mapper.Map<ResponseGenerico<ClimaResponse>>(response);
        }

        public async Task<ResponseGenerico<List<ClimaResponse>>> BuscarCondicaoCapital()
        {
            var response = await _brasilApi.BuscarCondicaoCapital();
            return _mapper.Map<ResponseGenerico<List<ClimaResponse>>>(response);
        }

        public async Task<ResponseGenerico<PrevisaoResponse>> BuscarPrevisaoMeteorologicaCidade(int codigoCidade)
        {
            var response = await _brasilApi.BuscarPrevisaoMeteorologicaCidade(codigoCidade);
            return _mapper.Map<ResponseGenerico<PrevisaoResponse>>(response);
        }

        public async Task<ResponseGenerico<PrevisaoResponse>> BuscarPrevisaoMeteorologicaCidadeDias(int codigoCidade, int dias)
        {
            var response = await _brasilApi.BuscarPrevisaoMeteorologicaCidadeDias(codigoCidade, dias);
            return _mapper.Map<ResponseGenerico<PrevisaoResponse>>(response);
        }

        public async Task<ResponseGenerico<OndasResponse>> BuscarPrevisaoOceanicaCidade(int codigoCidade)
        {
            var response = await _brasilApi.BuscarPrevisaoOceanicaCidade(codigoCidade);
            return _mapper.Map<ResponseGenerico<OndasResponse>>(response);
        }

        public async Task<ResponseGenerico<OndasResponse>> BuscarPrevisaoOceanicaCidadeDias(int codigoCidade, int dias)
        {
            var response = await _brasilApi.BuscarPrevisaoOceanicaCidadeDias(codigoCidade, dias);
            return _mapper.Map<ResponseGenerico<OndasResponse>>(response);
        }
    }
}
