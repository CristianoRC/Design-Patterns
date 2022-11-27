using criacionais.Implementations.FactoryMethod;
using criacionais.Implementations.Singleton;

//RunSingletonExample();
//RunFactoryMethod();
RunAbstractFactory();

static void RunSingletonExample()
{
    Console.WriteLine("Exemplo Singleton - Apenas uma bola por vez pode estar em campo, podemos criar apenas uma");
    var ball01 = Ball.GetBallInstance();
    Console.WriteLine($"{nameof(ball01)}: {ball01}");

    var ball02 = Ball.GetBallInstance();
    Console.WriteLine($"{nameof(ball02)}: {ball02}");
}

static void RunFactoryMethod()
{
    const decimal amount = 135.29m;
    var defaultUserInstance = FeeCalculatorFactory.GetInstance(false);
    var premiumUserInstance = FeeCalculatorFactory.GetInstance(true);

    Console.WriteLine($"Amount: {amount}");
    Console.WriteLine($"Default User: R${defaultUserInstance.Calculate(amount)}");
    Console.WriteLine($"Premium User: R${premiumUserInstance.Calculate(amount)}");
}

static void RunAbstractFactory()
{
}