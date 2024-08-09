namespace DesignPatterns.Behavioral.Strategy
{
    public class ShoppingCart(IDiscountStrategy discountStrategy)
    {
        private readonly IDiscountStrategy _discountStrategy = discountStrategy;

        public decimal TotalAmount { get; set; }

        public decimal CalculateTotalAmountAfterDiscount()
        {
            var discount = _discountStrategy.CalculateDiscount(TotalAmount);
            return TotalAmount - discount;
        }
    }

}
