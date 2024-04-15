namespace DesignPatterns.StrategyDesignPattern;

public class PrivateProduce : IStrategy
{
    public Opel Produce()
    {
        return new Opel("Özel");
    }
}