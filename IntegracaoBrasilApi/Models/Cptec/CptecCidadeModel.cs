using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class CptecCidadeModel
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        [JsonPropertyName("estado")]
        public string? Estado { get; set; }
    }
}
