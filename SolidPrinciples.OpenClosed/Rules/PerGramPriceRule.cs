using SolidPrinciples.OpenClosed.Contracts;
using SolidPrinciples.OpenClosed.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OpenClosed.Rules
{
    public class PerGramPriceRule : IPriceRule
    {
        public decimal CalculatePrice(OrderItem item)
        {
            return item.Quantity * 4m / 1000;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("WEIGHT");
        }
    }
}
