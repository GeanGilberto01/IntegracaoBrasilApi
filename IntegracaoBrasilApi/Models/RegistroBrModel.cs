using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class RegistroBrModel
    {
        [JsonPropertyName("status_code")]
        public int? StatusCode;

        [JsonPropertyName("status")]
        public string? Status;

        [JsonPropertyName("fqdn")]
        public string? Fqdn;

        [JsonPropertyName("hosts")]
        public List<string>? Hosts;

        [JsonPropertyName("publication-status")]
        public string? PublicationStatus;

        [JsonPropertyName("expires-at")]
        public DateTime? ExpiresAt;

        [JsonPropertyName("suggestions")]
        public List<string>? Suggestions;
    }
}
