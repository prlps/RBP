using System;

namespace AutoRent.Data.Models
{
    public class Rental
    {
        public int RentalId { get; set; }

        public int CarId { get; set; }
        public Car? Car { get; set; }

        public int ClientId { get; set; }
        public Client? Client { get; set; }

        public DateTime DateOut { get; set; }
        public DateTime PlannedReturnDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }

        public decimal PricePerDay { get; set; }
        public decimal? TotalPrice { get; set; }

        public string? Notes { get; set; }
    }
}
