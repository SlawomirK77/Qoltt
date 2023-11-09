namespace qoltt.Domain.Entities
{
    public class Tip
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public Category Category { get; set; }
        public List<ItemUri> Links { get; set; } = new();
        public decimal Rating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Guid? CreatedById { get; set; }
    }
}
