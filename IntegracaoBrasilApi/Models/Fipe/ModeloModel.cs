using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class ModeloModel
    {
        [JsonPropertyName("modelo")]
        public string? Modelo { get; set; }
    }
}
