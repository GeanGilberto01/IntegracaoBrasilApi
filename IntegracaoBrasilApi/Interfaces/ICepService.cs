using IntegracaoBrasilApi.DTOs;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface ICepService
    {
        Task<ResponseGenerico<CepResponse>> BuscarCep(string cep);

        Task<ResponseGenerico<CepResponse>> BuscarCepV2(string cep);
    }
}
