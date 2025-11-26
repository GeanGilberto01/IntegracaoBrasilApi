using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;

namespace IntegracaoBrasilApi.Services
{
    public class IbgeService : IIbgeService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public IbgeService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<List<MunicipioResponse>>> BuscarMunicipios(string siglaUF)
        {
            var response = await _brasilApi.BuscarMunicipios(siglaUF);
            return _mapper.Map<ResponseGenerico<List<MunicipioResponse>>>(response);
        }

        public async Task<ResponseGenerico<EstadoResponse>> BuscarEstado(string siglaUF)
        {
            var response = await _brasilApi.BuscarEstado(siglaUF);
            return _mapper.Map<ResponseGenerico<EstadoResponse>>(response);
        }

        public async Task<ResponseGenerico<List<EstadoResponse>>> BuscarTodosEstados()
        {
            var response = await _brasilApi.BuscarTodosEstados();
            return _mapper.Map<ResponseGenerico<List<EstadoResponse>>>(response);
        }
    }
}
