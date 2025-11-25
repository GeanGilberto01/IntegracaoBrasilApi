using IntegracaoBrasilApi.DTOs;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface ICambioService
    {
        Task<ResponseGenerico<List<MoedaResponse>>> BuscarMoedas();

        Task<ResponseGenerico<CambioResponse>> BuscarCambio(string moeda, string data);
    }
}
