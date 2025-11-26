using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IDddService
    {
        Task<ResponseGenerico<DddResponse>> BuscarDdds(int ddd);
    }
}
