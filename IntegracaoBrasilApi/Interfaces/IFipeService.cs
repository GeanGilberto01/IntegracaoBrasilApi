using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IFipeService
    {
        Task<ResponseGenerico<List<MarcaResponse>>> BuscarVeiculosMarcas(string tipoVeiculo);

        Task<ResponseGenerico<List<PrecoResponse>>> BuscarVeiculosPreco(string codigoFipe);

        Task<ResponseGenerico<List<TabelaResponse>>> BuscarTabelasFipe();

        Task<ResponseGenerico<List<ModeloResponse>>> BuscarVeiculosModelos(string tipoVeiculo, int codigoMarca);
    }
}
