namespace IntegracaoBrasilApi.DTOs
{
    public class CotacoResponse
    {
        public int? ParidadeCompra { get; set; }

        public int? ParidadeVenda { get; set; }

        public double? CotacaoCompra { get; set; }

        public double? CotacaoVenda { get; set; }

        public string? DataHoraCotacao { get; set; }

        public string? TipoBoletim { get; set; }
    }

    public class CambioResponse
    {
        public List<CotacoResponse>? Cotacoes { get; set; }

        public string? Moeda { get; set; }

        public string? Data { get; set; }
    }
}
