using criacionais.Implementations.Builder;
using criacionais.Implementations.FactoryMethod;
using criacionais.Implementations.Singleton;

//RunSingletonExample();
//RunFactoryMethod();
RunBuilder();

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

static void RunBuilder()
{
    var myItems = new[] {"Item 1", "Item 2", "Item 3", "Item 4"};
    var htmlReportBuilder = new HtmlReportBuilder();
    htmlReportBuilder
        .AddHeader()
        .AddSummary()
        .AddItems(myItems);

    var report = htmlReportBuilder.Build();
    Console.WriteLine($"FileName: {report.Name}.{report.Extension}");
    Console.WriteLine(report.Content);
}