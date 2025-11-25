using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class CepModel
    {
        [JsonPropertyName("cep")]
        public string? Cep { get; set; }

        [JsonPropertyName("state")]
        public string? Estado { get; set; }

        [JsonPropertyName("city")]
        public string? Cidade { get; set; }

        [JsonPropertyName("neighborhood")]
        public string? Bairro { get; set; }

        [JsonPropertyName("street")]
        public string? Rua { get; set; }

        [JsonPropertyName("service")]
        public string? Servico { get; set; }

        [JsonPropertyName("location")]
        public LocalizacaoModel? Localizacao { get; set; }
    }

    public class LocalizacaoModel
    {
        [JsonPropertyName("type")]
        public string? Tipo { get; set; }

        [JsonPropertyName("coordinates")]
        public CoordenadasModel? Coordenadas { get; set; }
    }

    public class CoordenadasModel
    {
        [JsonPropertyName("longitude")]
        public string? Longitude { get; set; }

        [JsonPropertyName("latitude")]
        public string? Latitude { get; set; }
    }
}
