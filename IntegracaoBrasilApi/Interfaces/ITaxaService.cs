using IntegracaoBrasilApi.DTOs;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface ITaxaService
    {
        Task<ResponseGenerico<List<TaxaResponse>>> BuscarTodasTaxas();

        Task<ResponseGenerico<TaxaResponse>> BuscarTaxa(string sigla);
    }
}
