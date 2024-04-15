namespace DesignPatterns.StrategyDesignPattern;

public class Opel
{
    public Opel(string productType)
    {
        Console.WriteLine($"Opel {productType} üretilmiştir.");
    }

    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int Km { get; set; }

}