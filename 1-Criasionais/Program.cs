using criacionais.Implementations.Singleton;

RunSingletonExample();

static void RunSingletonExample()
{
    Console.WriteLine("Exemplo Singleton - Apenas uma bola por vez pode estar em campo, podemos criar apenas uma");
    var ball01 = Ball.GetBallInstance();
    Console.WriteLine($"{nameof(ball01)}: {ball01}");
    
    var ball02 = Ball.GetBallInstance();
    Console.WriteLine($"{nameof(ball02)}: {ball02}");
}