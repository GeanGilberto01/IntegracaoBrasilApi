using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class CptecClimaModel
    {
        [JsonPropertyName("codigo_icao")]
        public string? CodigoIcao;

        [JsonPropertyName("atualizado_em")]
        public DateTime? AtualizadoEm;

        [JsonPropertyName("pressao_atmosferica")]
        public string? PressaoAtmosferica;

        [JsonPropertyName("visibilidade")]
        public string? Visibilidade;

        [JsonPropertyName("vento")]
        public int? Vento;

        [JsonPropertyName("direcao_vento")]
        public int? DirecaoVento;

        [JsonPropertyName("umidade")]
        public int? Umidade;

        [JsonPropertyName("condicao")]
        public string? Condicao;

        [JsonPropertyName("condicao_Desc")]
        public string? CondicaoDesc;

        [JsonPropertyName("temp")]
        public int? Temp;
    }
}
