using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class DddModel
    {
        [JsonPropertyName("state")]
        public string? Estado { get; set; }

        [JsonPropertyName("cities")]
        public List<string>? Cidades { get; set; }
    }
}
