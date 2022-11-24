namespace criacionais.Implementations.FactoryMethod;

public class DefaultClientFeeCalculator : IFeeCalculator
{
    public decimal Calculate(decimal amount)
    {
        return amount * 0.13m;
    }
}