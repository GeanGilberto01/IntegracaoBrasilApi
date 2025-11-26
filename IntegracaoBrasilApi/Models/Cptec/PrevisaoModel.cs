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
        public List<Clima>? Clima { get; set; }
    }

    public class Clima
    {
        [JsonPropertyName("data")]
        public string? Data;

        [JsonPropertyName("condicao")]
        public string? Condicao;

        [JsonPropertyName("min")]
        public int? Min;

        [JsonPropertyName("max")]
        public int? Max;

        [JsonPropertyName("indice_uv")]
        public int? IndiceUv;

        [JsonPropertyName("condicao_desc")]
        public string? CondicaoDesc;
    }
}
