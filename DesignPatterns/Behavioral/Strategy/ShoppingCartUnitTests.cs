namespace DesignPatterns.Behavioral.Strategy
{
    public class ShoppingCartUnitTests
    {
        [Fact]
        public void CalculateTotalAmountAfterDiscount_Should_WhenPercentageDiscount()
        {
            var totalAmount = 200;
            var percentageDiscount = 10;
            var cart = new ShoppingCart(new PercentageDiscountStrategy(percentageDiscount))
            {
                TotalAmount = totalAmount
            };

            var totalAmountAfterDiscount = cart.CalculateTotalAmountAfterDiscount();

            var totalAmountAfterDiscountCalculation = totalAmount - totalAmount * percentageDiscount / 100;
            Assert.Equal(totalAmountAfterDiscount, totalAmountAfterDiscountCalculation);
        }

        [Fact]
        public void CalculateTotalAmountAfterDiscount_Should_WhenFixedAmountDiscountStrategy()
        {
            var totalAmount = 200;
            var fixedDiscount = 10;
            var cart = new ShoppingCart(new FixedAmountDiscountStrategy(fixedDiscount))
            {
                TotalAmount = totalAmount
            };

            var totalAmountAfterDiscount = cart.CalculateTotalAmountAfterDiscount();

            var totalAmountAfterDiscountCalculation = totalAmount - fixedDiscount;
            Assert.Equal(totalAmountAfterDiscount, totalAmountAfterDiscountCalculation);
        }

        [Fact]
        public void CalculateTotalAmountAfterDiscount_Should_WhenNoDiscountStrategy()
        {
            var totalAmount = 200;
            var cart = new ShoppingCart(new NoDiscountStrategy())
            {
                TotalAmount = totalAmount
            };

            var totalAmountAfterDiscount = cart.CalculateTotalAmountAfterDiscount();

            Assert.Equal(totalAmountAfterDiscount, totalAmountAfterDiscount);
        }
    }
}