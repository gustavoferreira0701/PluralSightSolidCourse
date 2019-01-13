using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolidPrinciples.OpenClosed.Model;

namespace SolidPrinciples.Test
{
    [TestClass]
    public class CartTotalTest
    {
        private Cart _cart;

        [TestInitialize]
        public void Setup()
        {
            _cart = new Cart();
        }

        [TestMethod]
        public void ZeroWhenEmpty()
        {
            Assert.AreEqual(0, _cart.TotalAmount());
        }

        [TestMethod]
        public void FiveWithOneEachItem()
        {
            _cart.Add(new OrderItem { Quantity = 1, Sku = "EACH_WIDGET" });
            Assert.AreEqual(5m, _cart.TotalAmount());
        }

        [TestMethod]
        public void TwoWithHalfKiloWeightItem()
        {
            _cart.Add(new OrderItem { Quantity = 500, Sku = "WEIGHT_PEANUTS" });
            Assert.AreEqual(2m, _cart.TotalAmount());
        }

        [TestMethod]
        public void EightyCentsWithTwoSpecialItem()
        {
            _cart.Add(new OrderItem { Quantity = 2, Sku = "SPECIAL_CANDYBAR" });
            Assert.AreEqual(0.80m, _cart.TotalAmount());
        }

        [TestMethod]
        public void TwoDollarsWithSixSpecialItem()
        {
            _cart.Add(new OrderItem { Quantity = 6, Sku = "SPECIAL_CANDYBAR" });
            Assert.AreEqual(2m, _cart.TotalAmount());
        }

    }
}
