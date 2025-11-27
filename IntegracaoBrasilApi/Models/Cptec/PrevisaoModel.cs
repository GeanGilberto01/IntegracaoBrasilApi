using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class PrevisaoModel
    {
        [JsonPropertyName("cidade")]
        public string? Cidade { get; set; }

        [JsonPropertyName("estado")]
        public string? Estado { get; set; }

        [JsonPropertyName("atualizado_em")]
        public string? AtualizadoEm { get; set; }

        [JsonPropertyName("clima")]
        public List<TempoModel>? Clima { get; set; }
    }

    public class TempoModel
    {
        [JsonPropertyName("data")]
        public string? Data { get; set; }

        [JsonPropertyName("condicao")]
        public string? Condicao { get; set; }

        [JsonPropertyName("min")]
        public int? Min { get; set; }

        [JsonPropertyName("max")]
        public int? Max { get; set; }

        [JsonPropertyName("indice_uv")]
        public int? IndiceUv { get; set; }

        [JsonPropertyName("condicao_desc")]
        public string? CondicaoDesc { get; set; }
    }
}
