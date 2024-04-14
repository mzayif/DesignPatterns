namespace DesignPatterns.DependencyInjectionDesignPattern;

public class Motorcycle : IVehicle
{
    public void SpeedUp()
    {
        Console.WriteLine("Motorun gazına basıldır. Saatte 320 KM hızla gidiliyor");
    }

    public void SpeedDown()
    {
        Console.WriteLine("Motorun frenine basıldır. Motor Durdu");
        Console.WriteLine("=======================================");
    }
}