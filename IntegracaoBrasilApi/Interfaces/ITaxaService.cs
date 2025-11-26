using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface ITaxaService
    {
        Task<ResponseGenerico<List<TaxaResponse>>> BuscarTodasTaxas();

        Task<ResponseGenerico<TaxaResponse>> BuscarTaxa(string sigla);
    }
}
