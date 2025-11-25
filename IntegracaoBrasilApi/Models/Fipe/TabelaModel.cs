using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class TabelaModel
    {
        [JsonPropertyName("codigo")]
        public int? Codigo { get; set; }

        [JsonPropertyName("mes")]
        public string? Mes { get; set; }
    }
}
