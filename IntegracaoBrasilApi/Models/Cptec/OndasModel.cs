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
        public double? Vento;

        [JsonPropertyName("direcao_vento")]
        public string? DirecaoVento;

        [JsonPropertyName("direcao_vento_desc")]
        public string? DirecaoVentoDesc;

        [JsonPropertyName("altura_onda")]
        public double? AlturaOnda;

        [JsonPropertyName("direcao_onda")]
        public string? DirecaoOnda;

        [JsonPropertyName("direcao_onda_desc")]
        public string? DirecaoOndaDesc;

        [JsonPropertyName("agitacao")]
        public string? Agitacao;

        [JsonPropertyName("hora")]
        public string? Hora;
    }
}
