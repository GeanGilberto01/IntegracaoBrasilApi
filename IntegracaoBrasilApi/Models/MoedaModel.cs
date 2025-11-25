using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class MoedaModel
    {
        [JsonPropertyName("simbolo")]
        public string? Simbolo { get; set; }

        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        [JsonPropertyName("tipo_moeda")]
        public string? TipoMoeda { get; set; }
    }
}
