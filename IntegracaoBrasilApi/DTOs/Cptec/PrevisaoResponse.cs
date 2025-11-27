namespace IntegracaoBrasilApi.DTOs
{
    public class PrevisaoResponse
    {
        public string? Cidade { get; set; }

        public string? Estado { get; set; }

        public string? AtualizadoEm { get; set; }

        public List<TempoResponse>? Clima { get; set; }
    }

    public class TempoResponse
    {
        public string? Data;

        public string? Condicao;

        public int? Min;

        public int? Max;

        public int? IndiceUv;

        public string? CondicaoDesc;
    }
}
