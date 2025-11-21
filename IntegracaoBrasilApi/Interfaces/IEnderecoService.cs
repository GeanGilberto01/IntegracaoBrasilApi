using IntegracaoBrasilApi.DTOs;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}
