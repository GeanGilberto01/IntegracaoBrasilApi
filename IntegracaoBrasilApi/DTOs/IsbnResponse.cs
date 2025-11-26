namespace IntegracaoBrasilApi.DTOs
{
    public class DimensionsResponse
    {
        public double? Width;

        public double? Height;

        public string? Unit;
    }

    public class IsbnResponse
    {
        public string? Isbn;

        public string? Title;

        public object? Subtitle;

        public List<string>? Authors;

        public string? Publisher;

        public string? Synopsis;

        public DimensionsResponse? Dimensions;

        public int? Year;

        public string? Format;

        public int? PageCount;

        public List<string>? Subjects;

        public string? Location;

        public object? RetailPrice;

        public object? CoverUrl;

        public string? Provider;
    }
}
