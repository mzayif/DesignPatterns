namespace DesignPatterns.StrategyDesignPattern;

public class ProductionToOrder : IStrategy
{
    public Opel Produce()
    {
        return new Opel("Sipariş Üzerine");
    }
}