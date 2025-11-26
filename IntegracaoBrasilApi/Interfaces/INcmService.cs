using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface INcmService
    {
        Task<ResponseGenerico<List<NcmResponse>>> BuscarTodosNcms();

        Task<ResponseGenerico<List<NcmResponse>>> BuscarNcmsPorFiltro(string filtro);

        Task<ResponseGenerico<NcmResponse>> BuscarNcm(string codigo);
    }
}
