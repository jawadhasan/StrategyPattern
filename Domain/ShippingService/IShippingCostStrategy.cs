namespace StrategyPattern.Domain.ShippingService
{
    public interface IShippingCostStrategy
    {
        double Calculate(Order order);
    }
}
