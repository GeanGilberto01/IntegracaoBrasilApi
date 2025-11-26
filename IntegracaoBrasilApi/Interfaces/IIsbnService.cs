using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IIsbnService
    {
        Task<ResponseGenerico<IsbnResponse>> BuscarLivro(string isbn);
    }
}
