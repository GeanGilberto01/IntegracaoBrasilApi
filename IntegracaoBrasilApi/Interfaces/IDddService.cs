using IntegracaoBrasilApi.DTOs;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IDddService
    {
        Task<ResponseGenerico<DddResponse>> BuscarDdds(int ddd);
    }
}
