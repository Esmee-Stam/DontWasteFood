namespace DontWasteFood.UI.Models
{
    public class PackageViewModel
    {
        public required string Name;
        public DateTime DateOfPickUp;
        public required string MealType;
        public required string Location;
        public required string City;
        public bool Is18Plus;
        public decimal Price;
    }
}
