namespace DesignPatterns.Behavioral.Strategy
{
    public class PercentageDiscountStrategy : IDiscountStrategy
    {
        private readonly decimal _percentage;

        public PercentageDiscountStrategy(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal CalculateDiscount(decimal totalAmount)
        {
            return totalAmount * _percentage / 100;
        }
    }
}
