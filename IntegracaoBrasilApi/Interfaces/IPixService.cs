using IntegracaoBrasilApi.DTOs;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IPixService
    {
        Task<ResponseGenerico<List<PixParticipantesResponse>>> BuscarParticipantesPix();
    }
}
