namespace IntegracaoBrasilApi.DTOs
{
    public class ClimaResponse
    {
        public string? CodigoIcao { get; set; }

        public DateTime? AtualizadoEm { get; set; }

        public string? PressaoAtmosferica { get; set; }

        public string? Visibilidade { get; set; }

        public int? Vento { get; set; }

        public int? DirecaoVento { get; set; }

        public int? Umidade { get; set; }

        public string? Condicao { get; set; }

        public string? CondicaoDesc { get; set; }

        public int? Temp { get; set; }
    }
}
