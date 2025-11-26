namespace IntegracaoBrasilApi.DTOs
{
    public class RegiaoResponse
    {
        public int? Id { get; set; }

        public string? Sigla { get; set; }

        public string? Nome { get; set; }
    }

    public class EstadoResponse
    {
        public int? Id { get; set; }

        public string? Sigla { get; set; }

        public string? Nome { get; set; }

        public RegiaoResponse? Regiao { get; set; }
    }
}
