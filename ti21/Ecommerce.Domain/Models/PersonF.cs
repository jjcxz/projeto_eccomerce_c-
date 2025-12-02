namespace Ecommerce.Domain.Models
{
    public class PersonF : Person
    {
        public required string Name { get; set; }
        public required string CPF { get; set; }
    }
}