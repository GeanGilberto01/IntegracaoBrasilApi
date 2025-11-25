using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class MarcaModel
    {
        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        [JsonPropertyName("valor")]
        public string? Valor { get; set; }
    }
}
