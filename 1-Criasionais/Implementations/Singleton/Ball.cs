namespace criacionais.Implementations.Singleton;

/// <summary>
/// Ideia retirada do livro Design Patterns com C# - Rodrigo Gonçalves Santana
/// </summary>
public sealed class Ball
{
    private Ball(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public Guid Id { get; }
    public string Name { get; }

    private static Ball? _ball;

    public override string ToString()
    {
        return $"{Id} - {Name}";
    }

    public static Ball GetBallInstance()
    {
        if (_ball is null)
            _ball = new Ball(Guid.NewGuid(), "Bola única");
        return _ball;
    }
}