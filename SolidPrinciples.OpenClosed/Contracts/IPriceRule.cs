using System;
using System.Collections.Generic;
using System.Text;
using SolidPrinciples.OpenClosed.Model;

namespace SolidPrinciples.OpenClosed.Contracts
{
    public interface IPriceRule
    {
        bool IsMatch(OrderItem item);
        decimal CalculatePrice(OrderItem item);
    }
}
