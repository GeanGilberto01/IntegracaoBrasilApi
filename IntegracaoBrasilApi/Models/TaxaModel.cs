using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class TaxaModel
    {
        [JsonPropertyName("nome")]
        public string? Nome;

        [JsonPropertyName("valor")]
        public double? Valor;
    }
}
