using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;

namespace IntegracaoBrasilApi.Services
{
    public class FeriadoService : IFeriadoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public FeriadoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<List<FeriadoResponse>>> BuscarFeriados(int ano)
        {
            var response = await _brasilApi.BuscarFeriados(ano);
            return _mapper.Map<ResponseGenerico<List<FeriadoResponse>>>(response);
        }
    }
}
