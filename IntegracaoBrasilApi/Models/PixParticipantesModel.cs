using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class PixParticipantesModel
    {
        [JsonPropertyName("ispb")]
        public string? Ispb;

        [JsonPropertyName("nome")]
        public string? Nome;

        [JsonPropertyName("nome_reduzido")]
        public string? NomeReduzido;

        [JsonPropertyName("modalidade_participacao")]
        public string? ModalidadeParticipacao;

        [JsonPropertyName("tipo_participacao")]
        public string? TipoParticipacao;

        [JsonPropertyName("inicio_operacao")]
        public DateTime? InicioOperacao;
    }
}
