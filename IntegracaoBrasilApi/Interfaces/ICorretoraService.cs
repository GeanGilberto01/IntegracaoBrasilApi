using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface ICorretoraService
    {
        Task<ResponseGenerico<List<CorretoraResponse>>> BuscarTodasCorretoras();

        Task<ResponseGenerico<CorretoraResponse>> BuscarCorretora(string cnpj);
    }
}
