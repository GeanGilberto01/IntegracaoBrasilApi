using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IPixService
    {
        Task<ResponseGenerico<List<PixParticipantesResponse>>> BuscarParticipantesPix();
    }
}
