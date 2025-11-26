using Ecommerce.Domain.Models.Enums;
namespace Ecommerce.Domain.Models

{
    public class Order : Base
    {
        public required int Quantity { get; set; }
        public required PaymentMethodEnum PaymentMethod { get; set; }
        public required double Total { get; set; }
        public required double Subtotal { get; set; }
        public required int Code { get; set; }
        public required double UnitPrice { get; set; }
        public int Discount { get; set; }
        
    }
}