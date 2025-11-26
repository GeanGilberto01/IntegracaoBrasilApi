using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;

namespace IntegracaoBrasilApi.Services
{
    public class RegistroBrService : IRegistroBrService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public RegistroBrService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<RegistroBrResponse>> BuscarDadosDominio(string dominio)
        {
            var response = await _brasilApi.BuscarDadosDominio(dominio);
            return _mapper.Map<ResponseGenerico<RegistroBrResponse>>(response);
        }
    }
}
