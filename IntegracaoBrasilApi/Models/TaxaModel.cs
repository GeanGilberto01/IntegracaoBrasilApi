using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class TaxaModel
    {
        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        [JsonPropertyName("valor")]
        public double? Valor { get; set; }
    }
}
