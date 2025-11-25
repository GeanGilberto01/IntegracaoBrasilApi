using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();

        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);

        Task<ResponseGenerico<List<MoedaModel>>> BuscarMoedas();

        Task<ResponseGenerico<CambioModel>> BuscarCambio(string moeda, string data);

        Task<ResponseGenerico<CepModel>> BuscarCep(string cep);

        Task<ResponseGenerico<CepModel>> BuscarCepV2(string cep);

        Task<ResponseGenerico<CnpjModel>> BuscarCnpj(string cnpj);
    }
}
