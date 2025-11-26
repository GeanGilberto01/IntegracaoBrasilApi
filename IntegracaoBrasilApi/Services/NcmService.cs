using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;

namespace IntegracaoBrasilApi.Services
{
    public class NcmService : INcmService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public NcmService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<NcmResponse>> BuscarNcm(string codigo)
        {
            var response = await _brasilApi.BuscarNcm(codigo);
            return _mapper.Map<ResponseGenerico<NcmResponse>>(response);
        }

        public async Task<ResponseGenerico<List<NcmResponse>>> BuscarNcmsPorFiltro(string filtro)
        {
            var response = await _brasilApi.BuscarNcmsPorFiltro(filtro);
            return _mapper.Map<ResponseGenerico<List<NcmResponse>>>(response);
        }

        public async Task<ResponseGenerico<List<NcmResponse>>> BuscarTodosNcms()
        {
            var response = await _brasilApi.BuscarTodosNcms();
            return _mapper.Map<ResponseGenerico<List<NcmResponse>>>(response);
        }
    }
}
