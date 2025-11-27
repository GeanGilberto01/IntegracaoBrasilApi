using IntegracaoBrasilApi.DTOs;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IFeriadoService
    {
        Task<ResponseGenerico<List<FeriadoResponse>>> BuscarFeriados(int ano);
    }
}
