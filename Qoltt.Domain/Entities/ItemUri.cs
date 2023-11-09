namespace qoltt.Domain.Entities
{
    public class ItemUri
    {
        public Guid Id { get; set; }
        public Uri Uri { get; set; } = default!;
        public List<Product> Products { get; set; } = new();
        public List<Tip> Tips { get; set; } = new();
    }
}
