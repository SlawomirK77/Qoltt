namespace qoltt.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public ProductCategory Category { get; set; }
        public List<string> Links { get; set; } = new();
        public string? Picture { get; set; }
        public decimal Rating { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Guid? CreatedById { get; set; }
    }

    public enum ProductCategory
    {
        Software,
        Electronics,
        Fashion,
        HomeAndGarden,
        Supermarket,
        Kids,
        Beauty,
        Health,
        CultureAndEntertainment,
        SportsAndTravel,
        Automotive,
        CollectionsAndArt,
        BuisnessAndServices
    }
}