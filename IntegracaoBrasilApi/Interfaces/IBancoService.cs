using IntegracaoBrasilApi.DTOs;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos();
        Task<ResponseGenerico<BancoResponse>> BuscaBanco(string codigoBanco);
    }
}
