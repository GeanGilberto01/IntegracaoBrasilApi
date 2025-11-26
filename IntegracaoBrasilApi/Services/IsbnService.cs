using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;

namespace IntegracaoBrasilApi.Services
{
    public class IsbnService : IIsbnService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public IsbnService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<IsbnResponse>> BuscarLivro(string isbn)
        {
            var response = await _brasilApi.BuscarLivro(isbn);
            return _mapper.Map<ResponseGenerico<IsbnResponse>>(response);
        }
    }
}
