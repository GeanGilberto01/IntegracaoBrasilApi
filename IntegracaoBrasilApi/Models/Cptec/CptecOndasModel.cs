using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class CptecOndasModel
    {
        [JsonPropertyName("cidade")]
        public string? Cidade { get; set; }

        [JsonPropertyName("estado")]
        public string? Estado { get; set; }

        [JsonPropertyName("atualizado_em")]
        public string? AtualizadoEm { get; set; }

        [JsonPropertyName("ondas")]
        public List<Onda>? Ondas { get; set; }
    }

    public class Onda
    {
        [JsonPropertyName("data")]
        public string? Data { get; set; }

        [JsonPropertyName("dados_ondas")]
        public List<DadosOnda>? DadosOndas { get; set; }
    }

    public class DadosOnda
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
