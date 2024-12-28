namespace DontWasteFood.UI.Models
{
    public class ProductViewModel
    {
        public Guid ProductId { get; set; }
        public required string Name { get; set; }
        public bool IsAlcoholic { get; set; }
        public string? Photo { get; set; }
    }
}
