namespace AutoRent.Data.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;

        public override string ToString() => $"{LastName} {FirstName}";
    }
}
