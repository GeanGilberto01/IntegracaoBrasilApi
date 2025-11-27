using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class OndasModel
    {
        [JsonPropertyName("cidade")]
        public string? Cidade { get; set; }

        [JsonPropertyName("estado")]
        public string? Estado { get; set; }

        [JsonPropertyName("atualizado_em")]
        public string? AtualizadoEm { get; set; }

        [JsonPropertyName("ondas")]
        public List<OndaModel>? Ondas { get; set; }
    }

    public class OndaModel
    {
        [JsonPropertyName("data")]
        public string? Data { get; set; }

        [JsonPropertyName("dados_ondas")]
        public List<DadosOndaModel>? DadosOndas { get; set; }
    }

    public class DadosOndaModel
    {
        [JsonPropertyName("vento")]
        public double? Vento { get; set; }

        [JsonPropertyName("direcao_vento")]
        public string? DirecaoVento { get; set; }

        [JsonPropertyName("direcao_vento_desc")]
        public string? DirecaoVentoDesc { get; set; }

        [JsonPropertyName("altura_onda")]
        public double? AlturaOnda { get; set; }

        [JsonPropertyName("direcao_onda")]
        public string? DirecaoOnda { get; set; }

        [JsonPropertyName("direcao_onda_desc")]
        public string? DirecaoOndaDesc { get; set; }

        [JsonPropertyName("agitacao")]
        public string? Agitacao { get; set; }

        [JsonPropertyName("hora")]
        public string? Hora { get; set; }
    }
}
