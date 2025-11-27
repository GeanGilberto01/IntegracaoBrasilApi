namespace IntegracaoBrasilApi.DTOs
{
    public class DimensionsResponse
    {
        public double? Width { get; set; }

        public double? Height { get; set; }

        public string? Unit { get; set; }
    }

    public class IsbnResponse
    {
        public string? Isbn { get; set; }

        public string? Title { get; set; }

        public object? Subtitle { get; set; }

        public List<string>? Authors { get; set; }

        public string? Publisher { get; set; }

        public string? Synopsis { get; set; }

        public DimensionsResponse? Dimensions { get; set; }

        public int? Year { get; set; }

        public string? Format { get; set; }

        public int? PageCount { get; set; }

        public List<string>? Subjects { get; set; }

        public string? Location { get; set; }

        public object? RetailPrice { get; set; }

        public object? CoverUrl { get; set; }

        public string? Provider { get; set; }
    }
}
