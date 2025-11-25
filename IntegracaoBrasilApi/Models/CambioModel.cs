using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class CotacoModel
    {
        [JsonPropertyName("paridade_compra")]
        public double? ParidadeCompra { get; set; }

        [JsonPropertyName("paridade_venda")]
        public double? ParidadeVenda { get; set; }

        [JsonPropertyName("cotacao_compra")]
        public double? CotacaoCompra { get; set; }

        [JsonPropertyName("cotacao_venda")]
        public double? CotacaoVenda { get; set; }

        [JsonPropertyName("data_hora_cotacao")]
        public string? DataHoraCotacao { get; set; }

        [JsonPropertyName("tipo_boletim")]
        public string? TipoBoletim { get; set; }
    }

    public class CambioModel
    {
        [JsonPropertyName("cotacoes")]
        public List<CotacoModel>? Cotacoes { get; set; }

        [JsonPropertyName("moeda")]
        public string? Moeda { get; set; }

        [JsonPropertyName("data")]
        public string? Data { get; set; }
    }
}
