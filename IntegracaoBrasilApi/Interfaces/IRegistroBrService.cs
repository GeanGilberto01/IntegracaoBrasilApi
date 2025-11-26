using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IRegistroBrService
    {
        Task<ResponseGenerico<RegistroBrResponse>> BuscarDadosDominio(string dominio);
    }
}
