using SolidPrinciples.OpenClosed.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OpenClosed.Contracts
{
    public interface IPricingCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }
}
