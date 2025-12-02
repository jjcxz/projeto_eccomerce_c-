namespace Ecommerce.Domain.Models
{
    public abstract class Address : Base
    {
        public required string City { get; set; }
        public required string StreetAddress { get; set; }
        public required string Neighborhood { get; set; }
        public required string Number { get; set; }
    }
}