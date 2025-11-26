namespace Ecommerce.Domain.Models
{
    public class PersonJ : Person
    {
        public required string BusinessName { get; set; }
        public required string CNPJ { get; set; }
    }
}