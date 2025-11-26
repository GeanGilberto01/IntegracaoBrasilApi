using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;

namespace IntegracaoBrasilApi.Services
{
    public class BancoService : IBancoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public BancoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<BancoResponse>> BuscaBanco(int codigoBanco)
        {
            var response = await _brasilApi.BuscarBanco(codigoBanco);
            return _mapper.Map<ResponseGenerico<BancoResponse>>(response);
        }

        public async Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos()
        {
            var response = await _brasilApi.BuscarTodosBancos();
            return _mapper.Map<ResponseGenerico<List<BancoResponse>>>(response);
        }
    }
}
