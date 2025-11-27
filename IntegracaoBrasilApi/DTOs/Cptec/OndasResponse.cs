namespace IntegracaoBrasilApi.DTOs
{
    public class OndasResponse
    {
        public string? Cidade { get; set; }

        public string? Estado { get; set; }

        public string? AtualizadoEm { get; set; }

        public List<OndaResponse>? Ondas { get; set; }
    }

    public class OndaResponse
    {
        public string? Data { get; set; }

        public List<DadosOndaResponse>? DadosOndas { get; set; }
    }

    public class DadosOndaResponse
    {
        public double? Vento { get; set; }

        public string? DirecaoVento { get; set; }

        public string? DirecaoVentoDesc { get; set; }

        public double? AlturaOnda { get; set; }

        public string? DirecaoOnda { get; set; }

        public string? DirecaoOndaDesc { get; set; }

        public string? Agitacao { get; set; }

        public string? Hora { get; set; }
    }
}
