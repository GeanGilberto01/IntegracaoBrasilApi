using IntegracaoBrasilApi.DTOs;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface ICnpjService
    {
        Task<ResponseGenerico<CnpjResponse>> BuscarCnpj(string cnpj);
    }
}
