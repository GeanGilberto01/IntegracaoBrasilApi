using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class DimensionsModel
    {
        [JsonPropertyName("width")]
        public double? Width { get; set; }

        [JsonPropertyName("height")]
        public double? Height { get; set; }

        [JsonPropertyName("unit")]
        public string? Unit { get; set; }
    }

    public class IsbnModel
    {
        [JsonPropertyName("isbn")]
        public string? Isbn { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("subtitle")]
        public object? Subtitle { get; set; }

        [JsonPropertyName("authors")]
        public List<string>? Authors { get; set; }

        [JsonPropertyName("publisher")]
        public string? Publisher { get; set; }

        [JsonPropertyName("synopsis")]
        public string? Synopsis { get; set; }

        [JsonPropertyName("dimensions")]
        public DimensionsModel? Dimensions { get; set; }

        [JsonPropertyName("year")]
        public int? Year { get; set; }

        [JsonPropertyName("format")]
        public string? Format { get; set; }

        [JsonPropertyName("page_count")]
        public int? PageCount { get; set; }

        [JsonPropertyName("subjects")]
        public List<string>? Subjects { get; set; }

        [JsonPropertyName("location")]
        public string? Location { get; set; }

        [JsonPropertyName("retail_price")]
        public object? RetailPrice { get; set; }

        [JsonPropertyName("cover_url")]
        public object? CoverUrl { get; set; }

        [JsonPropertyName("provider")]
        public string? Provider { get; set; }
    }
}
