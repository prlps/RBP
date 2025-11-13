namespace AutoRent.Data.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Make { get; set; } = null!;
        public string Type { get; set; } = null!;
        public decimal PurchasePrice { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public bool IsAvailable { get; set; } = true;

        // Для отображения в ComboBox и т.п.
        public override string ToString() => $"{Make} ({Type})";
    }
}
