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
        public double? Vento;

        public string? DirecaoVento;

        public string? DirecaoVentoDesc;

        public double? AlturaOnda;

        public string? DirecaoOnda;

        public string? DirecaoOndaDesc;

        public string? Agitacao;

        public string? Hora;
    }
}
