using IntegracaoBrasilApi.DTOs;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface ICorretoraService
    {
        Task<ResponseGenerico<List<CorretoraResponse>>> BuscarTodasCorretoras();

        Task<ResponseGenerico<CorretoraResponse>> BuscarCorretora(string cnpj);
    }
}
