using Ecommerce.Domain.Models.Enums;

namespace Ecommerce.Domain.Models
{
    public class Product : Base
    {
        public required string Name { get; set; }
        public required string Price { get; set; }
        public required string Brand { get; set; }
        public required string Model { get; set; }
        public required string Description { get; set; }
        public string? Material { get; set; }
        public string? Color { get; set; }
        public required CategoryEnum Category { get; set; }
    }
}