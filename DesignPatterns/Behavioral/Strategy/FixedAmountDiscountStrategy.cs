namespace DesignPatterns.Behavioral.Strategy
{
    public class FixedAmountDiscountStrategy : IDiscountStrategy
    {
        private readonly decimal _fixedAmount;

        public FixedAmountDiscountStrategy(decimal fixedAmount)
        {
            _fixedAmount = fixedAmount;
        }

        public decimal CalculateDiscount(decimal totalAmount)
        {
            return _fixedAmount;
        }
    }

}
