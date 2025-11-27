namespace IntegracaoBrasilApi.DTOs
{
    public class RegistroBrResponse
    {
        public int? StatusCode { get; set; }

        public string? Status { get; set; }

        public string? Fqdn { get; set; }

        public List<string>? Hosts { get; set; }

        public string? PublicationStatus { get; set; }

        public DateTime? ExpiresAt { get; set; }

        public List<string>? Suggestions { get; set; }
    }
}
