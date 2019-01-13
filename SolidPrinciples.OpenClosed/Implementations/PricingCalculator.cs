using SolidPrinciples.OpenClosed.Contracts;
using SolidPrinciples.OpenClosed.Model;
using SolidPrinciples.OpenClosed.Rules;
using System.Collections.Generic;
using System.Linq;

namespace SolidPrinciples.OpenClosed.Implementations
{
    public class PricingCalculator : IPricingCalculator
    {
        private readonly List<IPriceRule> _pricingRules;

        public PricingCalculator()
        {
            _pricingRules = new List<IPriceRule>
            {
                new EachPriceRule(),
                new PerGramPriceRule(),
                new SpecialPriceRule(),
                new Buy4GetOneFree()
            };
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return _pricingRules.First(r => r.IsMatch(item)).CalculatePrice(item);
        }
    }
}
