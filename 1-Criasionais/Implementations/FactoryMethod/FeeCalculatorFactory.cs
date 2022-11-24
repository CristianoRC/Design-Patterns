namespace criacionais.Implementations.FactoryMethod;

/// <summary>
/// Não precisa ser sempre static, pois em alguns casos você cai precisar receber por injeção de dependência outras instâncias de serviços
/// </summary>
public static class FeeCalculatorFactory
{
    public static IFeeCalculator GetInstance(bool isPremiumClient)
    {
        return isPremiumClient ? new PremiumClientFeeCalculator() : new DefaultClientFeeCalculator();
    }
}