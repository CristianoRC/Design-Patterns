namespace criacionais.Implementations.FactoryMethod;

public class PremiumClientFeeCalculator : IFeeCalculator
{
    public decimal Calculate(decimal amount)
    {
        return amount * 0.05m;
    }
}