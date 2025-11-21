using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;

namespace IntegracaoBrasilApi.Rest
{
    public class CnpjService : ICnpjService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public CnpjService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<CnpjResponse>> BuscarCnpj(string cnpj)
        {
            var empresa = await _brasilApi.BuscarCnpj(cnpj);

            return _mapper.Map<ResponseGenerico<CnpjResponse>>(empresa);
        }
    }
}
