using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;

namespace IntegracaoBrasilApi.Services
{
    public class FipeService : IFipeService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public FipeService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<List<TabelaResponse>>> BuscarTabelasFipe()
        {
            var response = await _brasilApi.BuscarTabelasFipe();
            return _mapper.Map<ResponseGenerico<List<TabelaResponse>>>(response);
        }

        public async Task<ResponseGenerico<List<MarcaResponse>>> BuscarVeiculosMarcas(string tipoVeiculo)
        {
            var response = await _brasilApi.BuscarVeiculosMarcas(tipoVeiculo);
            return _mapper.Map<ResponseGenerico<List<MarcaResponse>>>(response);
        }

        public async Task<ResponseGenerico<List<ModeloResponse>>> BuscarVeiculosModelos(string tipoVeiculo, int codigoMarca)
        {
            var response = await _brasilApi.BuscarVeiculosModelos(tipoVeiculo, codigoMarca);
            return _mapper.Map<ResponseGenerico<List<ModeloResponse>>>(response);
        }

        public async Task<ResponseGenerico<List<PrecoResponse>>> BuscarVeiculosPreco(string codigoFipe)
        {
            var response = await _brasilApi.BuscarVeiculosPreco(codigoFipe);
            return _mapper.Map<ResponseGenerico<List<PrecoResponse>>>(response);
        }
    }
}
