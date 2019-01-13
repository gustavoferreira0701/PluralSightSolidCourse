using System.Collections.Generic;

namespace SolidPrinciples.OpenClosed.Model
{
    public class Cart
    {
        private readonly List<OrderItem> _items;

        public Cart()
        {
            _items = new List<OrderItem>();
        }


        public IEnumerable<OrderItem> Items
        {
            get { return _items; }
        }


        public string CustomerEmail { get; set; }

        public void Add(OrderItem orderItem)
        {
            _items.Add(orderItem);
        }

        public decimal TotalAmount()
        {
            decimal total = 0m;

            foreach (OrderItem item in Items)
            {
                if (item.Sku.StartsWith("EACH"))
                {
                    total += item.Quantity * 5m;
                }
                else if (item.Sku.StartsWith("WEIGHT"))
                {
                    total += item.Quantity * 4m / 1000;
                }
                else if (item.Sku.StartsWith("SPECIAL"))
                {
                    total += item.Quantity * .4m;
                    int setsOfThree = item.Quantity / 3;
                    total -= setsOfThree * .2m;
                }
            }

            return total;
        }

    }
}
