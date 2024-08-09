namespace DesignPatterns.Behavioral.Strategy
{
    public interface IDiscountStrategy
    {
        decimal CalculateDiscount(decimal totalAmount);
    }

}
