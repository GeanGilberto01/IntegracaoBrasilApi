using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class FeriadoModel
    {
        [JsonPropertyName("date")]
        public string? Data;

        [JsonPropertyName("name")]
        public string? Nome;

        [JsonPropertyName("type")]
        public string? Tipo;
    }
}
