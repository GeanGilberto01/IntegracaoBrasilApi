using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IIbgeService
    {
        Task<ResponseGenerico<List<MunicipioResponse>>> BuscarMunicipios(string siglaUF);

        Task<ResponseGenerico<List<EstadoResponse>>> BuscarTodosEstados();

        Task<ResponseGenerico<EstadoResponse>> BuscarEstado(string siglaUF);
    }
}
