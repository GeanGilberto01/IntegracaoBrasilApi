using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IFeriadoService
    {
        Task<ResponseGenerico<List<FeriadoResponse>>> BuscarFeriados(int ano);
    }
}
