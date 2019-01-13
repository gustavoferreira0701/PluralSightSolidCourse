using SolidPrinciples.OpenClosed.Contracts;
using SolidPrinciples.OpenClosed.Model;

namespace SolidPrinciples.OpenClosed.Rules
{
    public class EachPriceRule : IPriceRule
    {
        public decimal CalculatePrice(OrderItem item)
        {
            return item.Quantity * 5m;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("EACH");
        }
    }
}
