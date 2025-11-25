using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class NcmModel
    {
        [JsonPropertyName("codigo")]
        public string? Codigo;

        [JsonPropertyName("descricao")]
        public string? Descricao;

        [JsonPropertyName("data_inicio")]
        public string? DataInicio;

        [JsonPropertyName("data_fim")]
        public string? DataFim;

        [JsonPropertyName("tipo_ato")]
        public string? TipoAto;

        [JsonPropertyName("numero_ato")]
        public string? NumeroAto;

        [JsonPropertyName("ano_ato")]
        public string? AnoAto;
    }
}
