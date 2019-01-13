using SolidPrinciples.OpenClosed.Contracts;
using SolidPrinciples.OpenClosed.Model;
using System;

namespace SolidPrinciples.OpenClosed.Rules
{
    public class Buy4GetOneFree : IPriceRule
    {
        public decimal CalculatePrice(OrderItem item)
        {
            decimal total = 0m;
            total += item.Quantity * 1m;
            int setsOfThree = item.Quantity / 5;
            total -= setsOfThree * 1m;
            return total;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("B4GO");
        }
    }
}
