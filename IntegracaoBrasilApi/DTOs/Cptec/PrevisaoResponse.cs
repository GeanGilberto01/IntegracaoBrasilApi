
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
        public string? Data { get; set; }

        public string? Condicao { get; set; }

        public int? Min { get; set; }

        public int? Max { get; set; }

        public int? IndiceUv { get; set; }

        public string? CondicaoDesc { get; set; }
    }
}
