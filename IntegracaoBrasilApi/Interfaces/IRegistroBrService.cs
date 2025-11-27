using IntegracaoBrasilApi.DTOs;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IRegistroBrService
    {
        Task<ResponseGenerico<RegistroBrResponse>> BuscarDadosDominio(string dominio);
    }
}
