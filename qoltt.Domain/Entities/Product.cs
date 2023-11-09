namespace qoltt.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public Category Category { get; set; }
        public List<ItemUri> Links { get; set; } = new();
        public string? Picture { get; set; }
        public decimal Rating { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Guid? CreatedById { get; set; }
    }

    public enum Category
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