using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class MunicipioModel
    {
        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        [JsonPropertyName("codigo_ibge")]
        public string? CodigoIbge { get; set; }
    }
}
