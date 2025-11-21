using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEndereco(string cep);

        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();

        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);

        Task<ResponseGenerico<CnpjModel>> BuscarCnpj(string cnpj);
    }
}
