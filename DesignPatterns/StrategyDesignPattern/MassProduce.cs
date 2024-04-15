namespace DesignPatterns.StrategyDesignPattern;

public class MassProduce : IStrategy
{
    public Opel Produce()
    {
        return new Opel("Seri");
    }
}