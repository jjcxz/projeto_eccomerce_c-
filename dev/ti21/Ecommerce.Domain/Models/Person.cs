namespace Ecommerce.Domain.Models
{
    public class Person : Base
    {
        public required string Phone { get; set; }
        public required string Email { get; set; }
        public required Address Address { get; set; }

    }
}