namespace DesignPatterns.Behavioral.Strategy
{
    public class NoDiscountStrategy : IDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalAmount)
        {
            return 0;
        }
    }
}
