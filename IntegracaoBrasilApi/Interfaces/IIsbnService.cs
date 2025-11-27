using IntegracaoBrasilApi.DTOs;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IIsbnService
    {
        Task<ResponseGenerico<IsbnResponse>> BuscarLivro(string isbn);
    }
}
