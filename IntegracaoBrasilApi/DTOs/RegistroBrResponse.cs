namespace IntegracaoBrasilApi.DTOs
{
    public class RegistroBrResponse
    {
        public int? StatusCode;

        public string? Status;

        public string? Fqdn;

        public List<string>? Hosts;

        public string? PublicationStatus;

        public DateTime? ExpiresAt;

        public List<string>? Suggestions;
    }
}
