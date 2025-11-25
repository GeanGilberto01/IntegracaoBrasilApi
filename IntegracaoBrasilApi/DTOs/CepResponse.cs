using IntegracaoBrasilApi.Models;
using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.DTOs
{
    public class CepResponse
    {
        public string? Cep { get; set; }

        public string? Estado { get; set; }

        public string? Cidade { get; set; }

        public string? Bairro { get; set; }

        public string? Rua { get; set; }

        public LocalizacaResponse? Localizacao { get; set; }

        [JsonIgnore]
        public string? Servico { get; set; }
    }

    public class LocalizacaResponse
    {
        public string? Tipo { get; set; }

        public CoordenadasResponse? Coordenadas { get; set; }
    }

    public class CoordenadasResponse
    {
        public string? Longitude { get; set; }

        public string? Latitude { get; set; }
    }
}
