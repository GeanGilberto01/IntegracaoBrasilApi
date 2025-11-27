using IntegracaoBrasilApi.DTOs;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface INcmService
    {
        Task<ResponseGenerico<List<NcmResponse>>> BuscarTodosNcms();

        Task<ResponseGenerico<List<NcmResponse>>> BuscarNcmsPorFiltro(string filtro);

        Task<ResponseGenerico<NcmResponse>> BuscarNcm(string codigo);
    }
}
