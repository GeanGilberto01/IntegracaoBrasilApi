using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class RegiaoModel
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("sigla")]
        public string? Sigla { get; set; }

        [JsonPropertyName("nome")]
        public string? Nome { get; set; }
    }

    public class EstadoModel
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("sigla")]
        public string? Sigla { get; set; }

        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        [JsonPropertyName("regiao")]
        public RegiaoModel? Regiao { get; set; }
    }
}
