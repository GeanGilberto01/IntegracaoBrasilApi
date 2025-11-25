using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class Dimensions
    {
        [JsonPropertyName("width")]
        public double? Width;

        [JsonPropertyName("height")]
        public double? Height;

        [JsonPropertyName("unit")]
        public string? Unit;
    }

    public class IsbnModel
    {
        [JsonPropertyName("isbn")]
        public string? Isbn;

        [JsonPropertyName("title")]
        public string? Title;

        [JsonPropertyName("subtitle")]
        public object? Subtitle;

        [JsonPropertyName("authors")]
        public List<string>? Authors;

        [JsonPropertyName("publisher")]
        public string? Publisher;

        [JsonPropertyName("synopsis")]
        public string? Synopsis;

        [JsonPropertyName("dimensions")]
        public Dimensions? Dimensions;

        [JsonPropertyName("year")]
        public int? Year;

        [JsonPropertyName("format")]
        public string? Format;

        [JsonPropertyName("page_count")]
        public int? PageCount;

        [JsonPropertyName("subjects")]
        public List<string>? Subjects;

        [JsonPropertyName("location")]
        public string? Location;

        [JsonPropertyName("retail_price")]
        public object? RetailPrice;

        [JsonPropertyName("cover_url")]
        public object? CoverUrl;

        [JsonPropertyName("provider")]
        public string? Provider;
    }
}
